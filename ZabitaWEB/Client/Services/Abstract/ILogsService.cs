using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Zabita.Entities.Concrete;

namespace ZabitaWEB.Client.Services.Abstract
{
    public interface ILogsService
    {
        Task<IActionResult> DeleteLog(int id);

        Task<ActionResult<Log>> GetLog(int id);

        Task<ActionResult<IEnumerable<Log>>> GetLogs();

        Task<ActionResult<Log>> PostLog(Log log);

        Task<IActionResult> PutLog(int id, Log log);
    }
}