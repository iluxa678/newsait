using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using newsait.Domains;
using newsait.Repository;

namespace newsait.Controllers
{
    [ApiController]
    [Route("/operator")]
    public class OperatorController : ControllerBase
    {
        [HttpPatch("Moderation")]
        public Appeal Update(int AppealId, Appeal newAppeal)
        {
            return Storage.AppealStorage.Update(AppealId, newAppeal);
        }

        [HttpGet("ChoiseStatus")]
        public Status Read3(int StatusId)
        {
            return Storage.StatusStorage.Read(StatusId);
        }

        //

        [HttpPut("AddDiagnos")]
        public Diag Create(Diag diag)
        {
            Storage.DiagStorage.Create(diag);
            return diag;
        }

        [HttpPatch("ChangeDiag")]
        public Diag Update2(int DiagId, Diag newDiag)
        {
            return Storage.DiagStorage.Update(DiagId, newDiag);
        }

        [HttpDelete("DeleteDiag")]
        public bool Delete(int DiagId)
        {
            return Storage.DiagStorage.Delete(DiagId);
        }

        //

        [HttpPut("AddIll")]
        public Ill Create1(Ill ill)
        {
            Storage.IllStorage.Create(ill);
            return ill;
        }

        [HttpPatch("ChangeIll")]
        public Ill Update3(int IllId, Ill newIll)
        {
            return Storage.IllStorage.Update(IllId, newIll);
        }

        [HttpDelete("DeleteIll")]
        public bool Delete1(int IllId)
        {
            return Storage.IllStorage.Delete(IllId);
        }

        //

        [HttpPut("AddSimptom")]
        public Simptom Create2(Simptom simptom)
        {
            Storage.SimptomStorage.Create(simptom);
            return simptom;
        }

        [HttpPatch("ChangeSimptom")]
        public Simptom Update4(int SimptomId, Simptom newSimptom)
        {
            return Storage.SimptomStorage.Update(SimptomId, newSimptom);
        }

        [HttpDelete("DeleteSimptom")]
        public bool Delete2(int SimptomId)
        {
            return Storage.SimptomStorage.Delete(SimptomId);
        }

        //

        [HttpPut("AddReccomendation")]
        public Recomend Create3(Recomend recomend)
        {
            Storage.RecomendStorage.Create(recomend);
            return recomend;
        }

        [HttpPatch("ChangeReccomendation")]
        public Recomend Update5(int RecomendId, Recomend newRecomend)
        {
            return Storage.RecomendStorage.Update(RecomendId, newRecomend);
        }

        [HttpDelete("DeleteReccomendation")]
        public bool Delete3(int RecomendId)
        {
            return Storage.RecomendStorage.Delete(RecomendId);
        }

        //

        [HttpPut("AddMetod")]
        public Metod Create4(Metod metod)
        {
            Storage.MetodStorage.Create(metod);
            return metod;
        }

        [HttpPatch("ChangeMetod")]
        public Metod Update6(int MetodId, Metod newMetod)
        {
            return Storage.MetodStorage.Update(MetodId, newMetod);
        }

        [HttpDelete("DeleteMetod")]
        public bool Delete4(int MetodId)
        {
            return Storage.MetodStorage.Delete(MetodId);
        }

        //

        [HttpPut("AddService")]
        public Service Create5(Service service)
        {
            Storage.ServiceStorage.Create(service);
            return service;
        }

        [HttpPatch("ChangeService")]
        public Service Update7(int ServiceId, Service newService)
        {
            return Storage.ServiceStorage.Update(ServiceId, newService);
        }

        [HttpDelete("DeleteService")]
        public bool Delete5(int ServiceId)
        {
            return Storage.ServiceStorage.Delete(ServiceId);
        }

        //

        [HttpPut("AddStatus")]
        public Status Create6(Status status)
        {
            Storage.StatusStorage.Create(status);
            return status;
        }

        [HttpPatch("ChangeStatus")]
        public Status Update8(int StatusId, Status newStatus)
        {
            return Storage.StatusStorage.Update(StatusId, newStatus);
        }

        [HttpDelete("DeleteStatus")]
        public bool Delete6(int StatusId)
        {
            return Storage.StatusStorage.Delete(StatusId);
        }
    }
}
