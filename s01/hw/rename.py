def rename(file):
    f = open(file,'r+')
    lines = f.readlines
    lines[4]="    <TargetFramework>net8.0</TargetFramework>\n"
    f.write(lines)
    f.close()


    
