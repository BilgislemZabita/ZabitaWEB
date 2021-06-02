using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Zabita.Entities.Concrete;

namespace ZabitaWEB.Client.Services.Abstract

{
    public interface IAmirliksService
    {
        Task<IActionResult> DeleteAmirlik(int id);

        Task<ActionResult<Amirlik>> GetAmirlik(int id);

        Task<List<Amirlik>> GetAmirliks();

        Task<ActionResult<Amirlik>> PostAmirlik(Amirlik amirlik);

        Task<IActionResult> PutAmirlik(int id, Amirlik amirlik);
    }
}