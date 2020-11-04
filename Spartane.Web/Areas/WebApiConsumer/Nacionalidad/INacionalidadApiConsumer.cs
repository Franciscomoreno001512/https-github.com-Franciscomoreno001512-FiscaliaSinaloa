using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Nacionalidad
{
    public interface INacionalidadApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Nacionalidad.Nacionalidad>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Nacionalidad.Nacionalidad>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Nacionalidad.Nacionalidad> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Nacionalidad.NacionalidadPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData NacionalidadInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Nacionalidad.Nacionalidad entity, Spartane.Core.Domain.User.GlobalData NacionalidadInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Nacionalidad.Nacionalidad entity, Spartane.Core.Domain.User.GlobalData NacionalidadInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Nacionalidad.Nacionalidad>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Nacionalidad.Nacionalidad>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Nacionalidad.Nacionalidad>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Nacionalidad.NacionalidadPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Nacionalidad.Nacionalidad>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Nacionalidad.Nacionalidad_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Nacionalidad.Nacionalidad_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

