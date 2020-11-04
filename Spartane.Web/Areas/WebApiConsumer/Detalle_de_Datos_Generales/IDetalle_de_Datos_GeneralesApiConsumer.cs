using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Detalle_de_Datos_Generales
{
    public interface IDetalle_de_Datos_GeneralesApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Detalle_de_Datos_Generales.Detalle_de_Datos_Generales>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Detalle_de_Datos_Generales.Detalle_de_Datos_Generales>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Detalle_de_Datos_Generales.Detalle_de_Datos_Generales> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Detalle_de_Datos_Generales.Detalle_de_Datos_GeneralesPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Detalle_de_Datos_GeneralesInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Detalle_de_Datos_Generales.Detalle_de_Datos_Generales entity, Spartane.Core.Domain.User.GlobalData Detalle_de_Datos_GeneralesInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Detalle_de_Datos_Generales.Detalle_de_Datos_Generales entity, Spartane.Core.Domain.User.GlobalData Detalle_de_Datos_GeneralesInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Detalle_de_Datos_Generales.Detalle_de_Datos_Generales>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Detalle_de_Datos_Generales.Detalle_de_Datos_Generales>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Detalle_de_Datos_Generales.Detalle_de_Datos_Generales>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Detalle_de_Datos_Generales.Detalle_de_Datos_GeneralesPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Detalle_de_Datos_Generales.Detalle_de_Datos_Generales>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Detalle_de_Datos_Generales.Detalle_de_Datos_Generales_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Detalle_de_Datos_Generales.Detalle_de_Datos_Generales_Datos_Generales> Get_Datos_Generales(string Key);

		ApiResponse<int> Update_Datos_del_Tutor(Spartane.Core.Domain.Detalle_de_Datos_Generales.Detalle_de_Datos_Generales_Datos_del_Tutor entity);
		ApiResponse<Spartane.Core.Domain.Detalle_de_Datos_Generales.Detalle_de_Datos_Generales_Datos_del_Tutor> Get_Datos_del_Tutor(string Key);

		ApiResponse<int> Update_Representante_Legal(Spartane.Core.Domain.Detalle_de_Datos_Generales.Detalle_de_Datos_Generales_Representante_Legal entity);
		ApiResponse<Spartane.Core.Domain.Detalle_de_Datos_Generales.Detalle_de_Datos_Generales_Representante_Legal> Get_Representante_Legal(string Key);

		ApiResponse<int> Update_Datos_de_los_Hechos(Spartane.Core.Domain.Detalle_de_Datos_Generales.Detalle_de_Datos_Generales_Datos_de_los_Hechos entity);
		ApiResponse<Spartane.Core.Domain.Detalle_de_Datos_Generales.Detalle_de_Datos_Generales_Datos_de_los_Hechos> Get_Datos_de_los_Hechos(string Key);

		ApiResponse<int> Update_Datos_de_Media_Filiacion(Spartane.Core.Domain.Detalle_de_Datos_Generales.Detalle_de_Datos_Generales_Datos_de_Media_Filiacion entity);
		ApiResponse<Spartane.Core.Domain.Detalle_de_Datos_Generales.Detalle_de_Datos_Generales_Datos_de_Media_Filiacion> Get_Datos_de_Media_Filiacion(string Key);

		ApiResponse<int> Update_Desestimacion(Spartane.Core.Domain.Detalle_de_Datos_Generales.Detalle_de_Datos_Generales_Desestimacion entity);
		ApiResponse<Spartane.Core.Domain.Detalle_de_Datos_Generales.Detalle_de_Datos_Generales_Desestimacion> Get_Desestimacion(string Key);


    }
}

