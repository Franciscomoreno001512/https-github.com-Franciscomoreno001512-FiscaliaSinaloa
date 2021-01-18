using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Quejas_de_MP
{
    public interface IQuejas_de_MPApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Quejas_de_MP.Quejas_de_MP>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Quejas_de_MP.Quejas_de_MP>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Quejas_de_MP.Quejas_de_MP> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Quejas_de_MP.Quejas_de_MPPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Quejas_de_MPInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Quejas_de_MP.Quejas_de_MP entity, Spartane.Core.Domain.User.GlobalData Quejas_de_MPInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Quejas_de_MP.Quejas_de_MP entity, Spartane.Core.Domain.User.GlobalData Quejas_de_MPInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Quejas_de_MP.Quejas_de_MP>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Quejas_de_MP.Quejas_de_MP>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Quejas_de_MP.Quejas_de_MP>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Quejas_de_MP.Quejas_de_MPPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Quejas_de_MP.Quejas_de_MP>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Quejas_de_MP.Quejas_de_MP_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Quejas_de_MP.Quejas_de_MP_Datos_Generales> Get_Datos_Generales(string Key);

		ApiResponse<int> Update_Datos_de_Media_Filiacion(Spartane.Core.Domain.Quejas_de_MP.Quejas_de_MP_Datos_de_Media_Filiacion entity);
		ApiResponse<Spartane.Core.Domain.Quejas_de_MP.Quejas_de_MP_Datos_de_Media_Filiacion> Get_Datos_de_Media_Filiacion(string Key);

		ApiResponse<int> Update_Datos_de_los_Hechos(Spartane.Core.Domain.Quejas_de_MP.Quejas_de_MP_Datos_de_los_Hechos entity);
		ApiResponse<Spartane.Core.Domain.Quejas_de_MP.Quejas_de_MP_Datos_de_los_Hechos> Get_Datos_de_los_Hechos(string Key);

		ApiResponse<int> Update_Datos_de_Identificacion(Spartane.Core.Domain.Quejas_de_MP.Quejas_de_MP_Datos_de_Identificacion entity);
		ApiResponse<Spartane.Core.Domain.Quejas_de_MP.Quejas_de_MP_Datos_de_Identificacion> Get_Datos_de_Identificacion(string Key);

		ApiResponse<int> Update_Datos_de_Domicilio(Spartane.Core.Domain.Quejas_de_MP.Quejas_de_MP_Datos_de_Domicilio entity);
		ApiResponse<Spartane.Core.Domain.Quejas_de_MP.Quejas_de_MP_Datos_de_Domicilio> Get_Datos_de_Domicilio(string Key);


    }
}

