using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Zabita.Entities.Concrete;
using System;

namespace ZabitaWEB.Client.Services.Abstract

{
    public interface IAmirliksService
    {
        Task<ActionResult<bool>> DeleteAmirlik(int id);

        Task<ActionResult<Amirlik>> GetAmirlik(int id);

        Task<List<Amirlik>> GetAmirliks();

        Task<Uri> PostAmirlik(Amirlik amirlik);

        Task<ActionResult<bool>> PutAmirlik(int id, Amirlik amirlik);
    }
}