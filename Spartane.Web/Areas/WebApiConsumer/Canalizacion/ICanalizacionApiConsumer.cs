using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Canalizacion
{
    public interface ICanalizacionApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Canalizacion.Canalizacion>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Canalizacion.Canalizacion>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Canalizacion.Canalizacion> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Canalizacion.CanalizacionPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData CanalizacionInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Canalizacion.Canalizacion entity, Spartane.Core.Domain.User.GlobalData CanalizacionInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Canalizacion.Canalizacion entity, Spartane.Core.Domain.User.GlobalData CanalizacionInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Canalizacion.Canalizacion>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Canalizacion.Canalizacion>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Canalizacion.Canalizacion>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Canalizacion.CanalizacionPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Canalizacion.Canalizacion>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Canalizacion.Canalizacion_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Canalizacion.Canalizacion_Datos_Generales> Get_Datos_Generales(string Key);

		ApiResponse<int> Update_Resolucion(Spartane.Core.Domain.Canalizacion.Canalizacion_Resolucion entity);
		ApiResponse<Spartane.Core.Domain.Canalizacion.Canalizacion_Resolucion> Get_Resolucion(string Key);


    }
}

