using BrigittaBlazor.Models;

namespace BrigittaBlazor.Utils;

public static class MappoolUtils
{
    /*
     * Return a sorted List<Mappick> in following order:
     * NM, HD, HR, DT, FM, ...custom picks, TB
     */
    public static List<Mappick>? LoadMappool(string tourAbbr)
    {
#if DEBUG
        return
        [
            new Mappick("NM1", 1, 123456),
            new Mappick("NM2", 1, 123456),
            new Mappick("NM3", 1, 123456),
            new Mappick("NM4", 1, 123456),
            new Mappick("NM5", 1, 123456),
            new Mappick("HD1", 9, 123456),
            new Mappick("HD2", 9, 123456),
            new Mappick("HR1", 17, 123456),
            new Mappick("HR2", 17, 123456),
            new Mappick("DT1", 65, 123456),
            new Mappick("DT2", 65, 123456),
            new Mappick("DT3", 65, 123456),
            new Mappick("FM1", -1, 123456),
            new Mappick("TB", -1, 123456)
        ];
#endif

        return null;
    }
}