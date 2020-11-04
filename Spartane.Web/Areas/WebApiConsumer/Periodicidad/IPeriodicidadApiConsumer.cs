using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Periodicidad
{
    public interface IPeriodicidadApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Periodicidad.Periodicidad>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Periodicidad.Periodicidad>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Periodicidad.Periodicidad> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Periodicidad.PeriodicidadPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData PeriodicidadInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Periodicidad.Periodicidad entity, Spartane.Core.Domain.User.GlobalData PeriodicidadInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Periodicidad.Periodicidad entity, Spartane.Core.Domain.User.GlobalData PeriodicidadInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Periodicidad.Periodicidad>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Periodicidad.Periodicidad>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Periodicidad.Periodicidad>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Periodicidad.PeriodicidadPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Periodicidad.Periodicidad>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Periodicidad.Periodicidad_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Periodicidad.Periodicidad_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

