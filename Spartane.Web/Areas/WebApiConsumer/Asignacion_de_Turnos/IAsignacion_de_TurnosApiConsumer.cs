using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Asignacion_de_Turnos
{
    public interface IAsignacion_de_TurnosApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Asignacion_de_Turnos.Asignacion_de_Turnos>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Asignacion_de_Turnos.Asignacion_de_Turnos>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Asignacion_de_Turnos.Asignacion_de_Turnos> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Asignacion_de_Turnos.Asignacion_de_TurnosPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Asignacion_de_TurnosInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Asignacion_de_Turnos.Asignacion_de_Turnos entity, Spartane.Core.Domain.User.GlobalData Asignacion_de_TurnosInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Asignacion_de_Turnos.Asignacion_de_Turnos entity, Spartane.Core.Domain.User.GlobalData Asignacion_de_TurnosInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Asignacion_de_Turnos.Asignacion_de_Turnos>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Asignacion_de_Turnos.Asignacion_de_Turnos>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Asignacion_de_Turnos.Asignacion_de_Turnos>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Asignacion_de_Turnos.Asignacion_de_TurnosPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Asignacion_de_Turnos.Asignacion_de_Turnos>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Asignacion_de_Turnos.Asignacion_de_Turnos_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Asignacion_de_Turnos.Asignacion_de_Turnos_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

