using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TMS_Manager
{
    public enum EnumSearchOption
    {
        전체,
        무핵탈립성,
        착색도,
        병해,
        충해,
        장해
    }

    public enum EnumTreeType
    {
        전체,
        거봉,
        하니,
        자옥,        
        홍부사,
        탐나라,
        결주,
        수확끝,
        결실불량
    }

    public enum EnumBug
    {
        미선택,
        깍지벌레,
        꽃매미,
        응애,
        애매미충,
        총채벌레,
        도롱이,
        잎벌레
    }

    public enum EnumPeriod
    {
        미선택,
        고온장해,
        저온장해
    }

    public enum EnumDisease
    {
        미선택,
        탄저병,
        갈반병,
        새눈무늬병,
        노균병
    }

    public enum EnumGrade
    {
        용이,
        보통,
        나쁨
    }
}
