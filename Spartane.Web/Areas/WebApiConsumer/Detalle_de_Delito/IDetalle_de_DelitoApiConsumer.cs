using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Detalle_de_Delito
{
    public interface IDetalle_de_DelitoApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Detalle_de_Delito.Detalle_de_Delito>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Detalle_de_Delito.Detalle_de_Delito>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Detalle_de_Delito.Detalle_de_Delito> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Detalle_de_Delito.Detalle_de_DelitoPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Detalle_de_DelitoInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Detalle_de_Delito.Detalle_de_Delito entity, Spartane.Core.Domain.User.GlobalData Detalle_de_DelitoInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Detalle_de_Delito.Detalle_de_Delito entity, Spartane.Core.Domain.User.GlobalData Detalle_de_DelitoInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Detalle_de_Delito.Detalle_de_Delito>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Detalle_de_Delito.Detalle_de_Delito>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Detalle_de_Delito.Detalle_de_Delito>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Detalle_de_Delito.Detalle_de_DelitoPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Detalle_de_Delito.Detalle_de_Delito>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Detalle_de_Delito.Detalle_de_Delito_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Detalle_de_Delito.Detalle_de_Delito_Datos_Generales> Get_Datos_Generales(string Key);

		ApiResponse<int> Update_Datos_de_Robo_de_Vehiculo(Spartane.Core.Domain.Detalle_de_Delito.Detalle_de_Delito_Datos_de_Robo_de_Vehiculo entity);
		ApiResponse<Spartane.Core.Domain.Detalle_de_Delito.Detalle_de_Delito_Datos_de_Robo_de_Vehiculo> Get_Datos_de_Robo_de_Vehiculo(string Key);

		ApiResponse<int> Update_Datos_del_Levantamiento_del_Cadaver(Spartane.Core.Domain.Detalle_de_Delito.Detalle_de_Delito_Datos_del_Levantamiento_del_Cadaver entity);
		ApiResponse<Spartane.Core.Domain.Detalle_de_Delito.Detalle_de_Delito_Datos_del_Levantamiento_del_Cadaver> Get_Datos_del_Levantamiento_del_Cadaver(string Key);

		ApiResponse<int> Update_Asignar_Dueno(Spartane.Core.Domain.Detalle_de_Delito.Detalle_de_Delito_Asignar_Dueno entity);
		ApiResponse<Spartane.Core.Domain.Detalle_de_Delito.Detalle_de_Delito_Asignar_Dueno> Get_Asignar_Dueno(string Key);


    }
}

