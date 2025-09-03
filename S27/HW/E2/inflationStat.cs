using System.IO.Compression;
using System.Security.Cryptography.X509Certificates;

public class InflationStat
{
    public string? Country { get; set; }
    public string? CountryCode { get; set; }
    public Dictionary<int, double> inflation = new Dictionary<int, double>();

    public double this[int index]
    {
        get
        {
            if (inflation.ContainsKey(index))
            {
                return Math.Round(inflation[index], 2);
            }
            return 0;
        }
    }
    public static InflationStat Parse(string data_line, string header_line)
    {
        var data = data_line.Split(',')
         .Select(x => x.Trim('"', ' '))
         .ToArray();

        var header = header_line.Split(',')
                                .Select(x => x.Trim().Trim('"'))
                                .ToArray();

        InflationStat stat = new InflationStat();
        stat.Country = data[0];
        stat.CountryCode = data[1];
        for (int i = 0; i <Math.Min(header.Length , data.Length); i++)
        {
            if (int.TryParse(header[i], out var year))
            {
                if (double.TryParse(data[i], out var value))
                {
                    stat.inflation[year] = Math.Round(value,2);
                }
                else
                {
                    stat.inflation[year] = 0;
                }
            }
        }

        return stat;
    }

}

public static class StringExtentions
{
    public static IEnumerable<InflationStat> ParseInflationFile(this string[] lines)
    {
        if (lines.Length > 1)
        {
            var header = lines[4];
            return lines
            .Skip(5)
            .Select(x => InflationStat.Parse(x, header));
        }
        return Enumerable.Empty<InflationStat>();
    }

    public static IEnumerable<(int yeat, double inflation)> HighestNYears(this IEnumerable<InflationStat> data, string country, int n)
    {
        var ans = data.FirstOrDefault(x => x.Country.ToLower().Contains(country))
                                .inflation.OrderByDescending(x => x.Value)
                                            .Take(n)
                                            .Select(x => (x.Key, Math.Round(x.Value, 2)));
        return ans;
    }

    public static IEnumerable<(int year, double inflation)> LowestNYears(this IEnumerable<InflationStat> data, string country, int n)
    {
        var ans = data.FirstOrDefault(x => x.Country.ToLower().Contains(country))
                                      .inflation.OrderBy(x => x.Value)
                                      .Where(x => x.Value != 0)
                                       .Take(n)
                                       .Select(x => (x.Key, Math.Round(x.Value, 2)));
        return ans;
    }

    public static IEnumerable<(string countryName, double inflation)> HighestNInYear(this IEnumerable<InflationStat> data, int year, int n)
    {
        var ans = data.OrderByDescending(x => x[year])
                        .Where(x => x[year] != 0)
                      .Take(n)
                      .Select(x => (x.Country, Math.Round(x[year], 2)));
        return ans;
    }

    public static IEnumerable<(string countryName, double inflation)> LowestNInYear(this IEnumerable<InflationStat> data, int year, int n)
    {
        var ans = data.OrderBy(x => x[year])
                        .Where(x => x[year] != 0)
                       .Take(n)
                       .Select(x => (x.Country, Math.Round(x[year], 2)));

        return ans;
    }

    public static IEnumerable<(string countryName, double inflation)> HighestNWhenLowest(this IEnumerable<InflationStat> data, string country, int n)
    {
        var year = data.FirstOrDefault(x => x.Country.ToLower().Contains(country))
                        .inflation.OrderBy(x => x.Value)
                        .First().Key;

        return data.HighestNInYear(year, n);
    }


    public static IEnumerable<(string countryName, double inflation)> LowestNWhenHighest(this IEnumerable<InflationStat> data, string country, int n)
    {
        var year = data.FirstOrDefault(x => x.Country.ToLower().Contains(country))
                        .inflation.OrderByDescending(x => x.Value)
                        .First().Key;

        return data.LowestNInYear(year, n);
    }

    public static IEnumerable<(int year, double inflation, int yearAfter, double inflationAfter)> HighestNImprovementsInCountry(this IEnumerable<InflationStat> data, string country, int n)
    {
        var inflation = data.FirstOrDefault(x => x.Country.ToLower().Contains(country)).inflation.Where(x => x.Value != 0).Select(x => (x.Key, x.Value)).ToArray();
        var Years = inflation.Take(inflation.Length - 1).ToArray();
        var AfterYears = inflation.Skip(1).ToArray();

        var diffs = Years.Zip(AfterYears, (y, a) => (Years: (y.Key, y.Value, a.Key, a.Value), diff: a.Value - y.Value));
        var ans = diffs.OrderBy(x => x.diff).Take(n).Select(x => x.Years);
        return ans;
    }
    public static IEnumerable<(int year, double inflation, int yearAfter, double inflationAfter)> LowestNImprovementsInCountry(this IEnumerable<InflationStat> data, string country, int n)
    {
        var inflation = data.FirstOrDefault(x => x.Country.ToLower().Contains(country)).inflation.Where(x => x.Value != 0).Select(x => (x.Key, x.Value)).ToArray();
        var Years = inflation.Take(inflation.Length - 1).ToArray();
        var AfterYears = inflation.Skip(1).ToArray();

        var diffs = Years.Zip(AfterYears, (y, a) => (Years: (y.Key, y.Value, a.Key, a.Value), diff: a.Value - y.Value));
        var ans = diffs.OrderByDescending(x => x.diff).Take(n).Select(x => x.Years);
        return ans;
    }

    public static IEnumerable<(string country, int y1, double r1, int y2, double r2)> HighestNImprovements(this IEnumerable<InflationStat> data, int n)
    {
        var ans = data.SelectMany(x =>
                data.LowestNImprovementsInCountry(x.Country, n)
                 .Select(y => (
                     country: x.Country,
                     y1: y.year,
                     r1: y.inflation,
                     y2: y.yearAfter,
                     r2: y.inflationAfter,
                     diff: y.inflationAfter - y.inflation
         )))
        .OrderBy(x => x.diff) // مرتب‌سازی برای بزرگ‌ترین کاهش‌ها
        .Take(n)
        .Select(
            x =>
            (Country: x.country,
             year1: x.y1,
             inf1: x.r1,
             year2: x.y2,
             inf2 : x.r2
            )
        );

        return ans;
        }

    public static IEnumerable<(string country, int y1, double r1, int y2, double r2)> LowestNImprovements(this IEnumerable<InflationStat> data, int count)
    {
        var ListImprov = new List<(string c, int y1, double r1, int y2, double r2)>();
        foreach (var item in data)
        {
            var yearsindexing = item.inflation.Keys.OrderBy(y => y).ToList();
            for (int i = 0; i < yearsindexing.Count - 1; i++)
            {
                int year1 = yearsindexing[i];
                int year2 = yearsindexing[i + 1];
                double year1r = item[year1];
                double year2r = item[year2];
                ListImprov.Add((item.Country, year1, year1r, year2, year2r));
            }
        }
        // return ListImprov
        //     .OrderBy(x => x.Item3 - x.Item5)
        //     .Take(count);
        foreach (var i in ListImprov.OrderBy(x => x.Item3 - x.Item5).Take(count))
        {
            yield return i;
        }

    }
}
