using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Servicio_del_Vehiculo
{
    public interface IServicio_del_VehiculoApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Servicio_del_Vehiculo.Servicio_del_Vehiculo>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Servicio_del_Vehiculo.Servicio_del_Vehiculo>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Servicio_del_Vehiculo.Servicio_del_Vehiculo> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Servicio_del_Vehiculo.Servicio_del_VehiculoPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Servicio_del_VehiculoInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Servicio_del_Vehiculo.Servicio_del_Vehiculo entity, Spartane.Core.Domain.User.GlobalData Servicio_del_VehiculoInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Servicio_del_Vehiculo.Servicio_del_Vehiculo entity, Spartane.Core.Domain.User.GlobalData Servicio_del_VehiculoInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Servicio_del_Vehiculo.Servicio_del_Vehiculo>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Servicio_del_Vehiculo.Servicio_del_Vehiculo>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Servicio_del_Vehiculo.Servicio_del_Vehiculo>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Servicio_del_Vehiculo.Servicio_del_VehiculoPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Servicio_del_Vehiculo.Servicio_del_Vehiculo>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Servicio_del_Vehiculo.Servicio_del_Vehiculo_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Servicio_del_Vehiculo.Servicio_del_Vehiculo_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

