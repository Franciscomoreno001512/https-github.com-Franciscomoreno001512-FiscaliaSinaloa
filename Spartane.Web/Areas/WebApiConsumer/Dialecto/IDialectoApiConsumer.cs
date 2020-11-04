using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Dialecto
{
    public interface IDialectoApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Dialecto.Dialecto>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Dialecto.Dialecto>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Dialecto.Dialecto> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Dialecto.DialectoPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData DialectoInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Dialecto.Dialecto entity, Spartane.Core.Domain.User.GlobalData DialectoInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Dialecto.Dialecto entity, Spartane.Core.Domain.User.GlobalData DialectoInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Dialecto.Dialecto>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Dialecto.Dialecto>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Dialecto.Dialecto>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Dialecto.DialectoPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Dialecto.Dialecto>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Dialecto.Dialecto_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Dialecto.Dialecto_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

