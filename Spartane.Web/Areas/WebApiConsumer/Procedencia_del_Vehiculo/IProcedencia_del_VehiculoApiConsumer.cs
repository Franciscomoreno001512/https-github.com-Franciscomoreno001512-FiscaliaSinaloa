using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Procedencia_del_Vehiculo
{
    public interface IProcedencia_del_VehiculoApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Procedencia_del_Vehiculo.Procedencia_del_Vehiculo>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Procedencia_del_Vehiculo.Procedencia_del_Vehiculo>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Procedencia_del_Vehiculo.Procedencia_del_Vehiculo> GetByKey(short Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Procedencia_del_Vehiculo.Procedencia_del_VehiculoPagingModel> GetByKeyComplete(short Key);
        ApiResponse<bool> Delete(short Key, Spartane.Core.Domain.User.GlobalData Procedencia_del_VehiculoInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int16> Insert(Spartane.Core.Domain.Procedencia_del_Vehiculo.Procedencia_del_Vehiculo entity, Spartane.Core.Domain.User.GlobalData Procedencia_del_VehiculoInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int16> Update(Spartane.Core.Domain.Procedencia_del_Vehiculo.Procedencia_del_Vehiculo entity, Spartane.Core.Domain.User.GlobalData Procedencia_del_VehiculoInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Procedencia_del_Vehiculo.Procedencia_del_Vehiculo>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Procedencia_del_Vehiculo.Procedencia_del_Vehiculo>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Procedencia_del_Vehiculo.Procedencia_del_Vehiculo>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Procedencia_del_Vehiculo.Procedencia_del_VehiculoPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Procedencia_del_Vehiculo.Procedencia_del_Vehiculo>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<short> GenerateID();
		ApiResponse<short> Update_Datos_Generales(Spartane.Core.Domain.Procedencia_del_Vehiculo.Procedencia_del_Vehiculo_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Procedencia_del_Vehiculo.Procedencia_del_Vehiculo_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

