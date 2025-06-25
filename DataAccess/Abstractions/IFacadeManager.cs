using System.Collections.Generic;
using System;
using DataAccess.Models;

public interface IFacadeManager
{
    List<Deal> ListDeals();
    bool SignDeal(int dealId, DateTime dateOfSign);
    void UpdateVacancy(int vacancyId, string info, string status);
}