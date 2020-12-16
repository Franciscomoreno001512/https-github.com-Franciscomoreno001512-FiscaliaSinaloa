using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Ubicacion_de_Medio_de_Transporte
{
    public interface IUbicacion_de_Medio_de_TransporteApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Ubicacion_de_Medio_de_Transporte.Ubicacion_de_Medio_de_Transporte>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Ubicacion_de_Medio_de_Transporte.Ubicacion_de_Medio_de_Transporte>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Ubicacion_de_Medio_de_Transporte.Ubicacion_de_Medio_de_Transporte> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Ubicacion_de_Medio_de_Transporte.Ubicacion_de_Medio_de_TransportePagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Ubicacion_de_Medio_de_TransporteInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Ubicacion_de_Medio_de_Transporte.Ubicacion_de_Medio_de_Transporte entity, Spartane.Core.Domain.User.GlobalData Ubicacion_de_Medio_de_TransporteInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Ubicacion_de_Medio_de_Transporte.Ubicacion_de_Medio_de_Transporte entity, Spartane.Core.Domain.User.GlobalData Ubicacion_de_Medio_de_TransporteInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Ubicacion_de_Medio_de_Transporte.Ubicacion_de_Medio_de_Transporte>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Ubicacion_de_Medio_de_Transporte.Ubicacion_de_Medio_de_Transporte>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Ubicacion_de_Medio_de_Transporte.Ubicacion_de_Medio_de_Transporte>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Ubicacion_de_Medio_de_Transporte.Ubicacion_de_Medio_de_TransportePagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Ubicacion_de_Medio_de_Transporte.Ubicacion_de_Medio_de_Transporte>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Ubicacion_de_Medio_de_Transporte.Ubicacion_de_Medio_de_Transporte_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Ubicacion_de_Medio_de_Transporte.Ubicacion_de_Medio_de_Transporte_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

