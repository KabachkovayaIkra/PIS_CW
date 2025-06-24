using System.Collections.Generic;
using System;

public interface IFacadeManager
{
    List<Deal> ListDeals();
    bool SignDeal(int dealId, DateTime dateOfSign);
    void UpdateVacancy(int vacancyId, string info, string status);
}