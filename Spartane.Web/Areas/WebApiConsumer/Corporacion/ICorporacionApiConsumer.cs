using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Corporacion
{
    public interface ICorporacionApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Corporacion.Corporacion>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Corporacion.Corporacion>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Corporacion.Corporacion> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Corporacion.CorporacionPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData CorporacionInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Corporacion.Corporacion entity, Spartane.Core.Domain.User.GlobalData CorporacionInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Corporacion.Corporacion entity, Spartane.Core.Domain.User.GlobalData CorporacionInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Corporacion.Corporacion>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Corporacion.Corporacion>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Corporacion.Corporacion>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Corporacion.CorporacionPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Corporacion.Corporacion>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Corporacion.Corporacion_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Corporacion.Corporacion_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

