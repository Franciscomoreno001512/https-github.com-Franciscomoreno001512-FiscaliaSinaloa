using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Calendario_de_Citas
{
    public interface ICalendario_de_CitasApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Calendario_de_Citas.Calendario_de_Citas>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Calendario_de_Citas.Calendario_de_Citas>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Calendario_de_Citas.Calendario_de_Citas> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Calendario_de_Citas.Calendario_de_CitasPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Calendario_de_CitasInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Calendario_de_Citas.Calendario_de_Citas entity, Spartane.Core.Domain.User.GlobalData Calendario_de_CitasInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Calendario_de_Citas.Calendario_de_Citas entity, Spartane.Core.Domain.User.GlobalData Calendario_de_CitasInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Calendario_de_Citas.Calendario_de_Citas>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Calendario_de_Citas.Calendario_de_Citas>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Calendario_de_Citas.Calendario_de_Citas>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Calendario_de_Citas.Calendario_de_CitasPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Calendario_de_Citas.Calendario_de_Citas>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Calendario_de_Citas.Calendario_de_Citas_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Calendario_de_Citas.Calendario_de_Citas_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

