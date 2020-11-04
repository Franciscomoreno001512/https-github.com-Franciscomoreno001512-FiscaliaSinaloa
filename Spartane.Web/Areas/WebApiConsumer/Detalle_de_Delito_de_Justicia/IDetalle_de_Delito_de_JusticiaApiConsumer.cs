using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Detalle_de_Delito_de_Justicia
{
    public interface IDetalle_de_Delito_de_JusticiaApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Detalle_de_Delito_de_Justicia.Detalle_de_Delito_de_Justicia>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Detalle_de_Delito_de_Justicia.Detalle_de_Delito_de_Justicia>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Detalle_de_Delito_de_Justicia.Detalle_de_Delito_de_Justicia> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Detalle_de_Delito_de_Justicia.Detalle_de_Delito_de_JusticiaPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Detalle_de_Delito_de_JusticiaInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Detalle_de_Delito_de_Justicia.Detalle_de_Delito_de_Justicia entity, Spartane.Core.Domain.User.GlobalData Detalle_de_Delito_de_JusticiaInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Detalle_de_Delito_de_Justicia.Detalle_de_Delito_de_Justicia entity, Spartane.Core.Domain.User.GlobalData Detalle_de_Delito_de_JusticiaInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Detalle_de_Delito_de_Justicia.Detalle_de_Delito_de_Justicia>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Detalle_de_Delito_de_Justicia.Detalle_de_Delito_de_Justicia>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Detalle_de_Delito_de_Justicia.Detalle_de_Delito_de_Justicia>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Detalle_de_Delito_de_Justicia.Detalle_de_Delito_de_JusticiaPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Detalle_de_Delito_de_Justicia.Detalle_de_Delito_de_Justicia>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Detalle_de_Delito_de_Justicia.Detalle_de_Delito_de_Justicia_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Detalle_de_Delito_de_Justicia.Detalle_de_Delito_de_Justicia_Datos_Generales> Get_Datos_Generales(string Key);

		ApiResponse<int> Update_Datos_de_Robo_de_Vehiculo(Spartane.Core.Domain.Detalle_de_Delito_de_Justicia.Detalle_de_Delito_de_Justicia_Datos_de_Robo_de_Vehiculo entity);
		ApiResponse<Spartane.Core.Domain.Detalle_de_Delito_de_Justicia.Detalle_de_Delito_de_Justicia_Datos_de_Robo_de_Vehiculo> Get_Datos_de_Robo_de_Vehiculo(string Key);

		ApiResponse<int> Update_Asignar_Dueno(Spartane.Core.Domain.Detalle_de_Delito_de_Justicia.Detalle_de_Delito_de_Justicia_Asignar_Dueno entity);
		ApiResponse<Spartane.Core.Domain.Detalle_de_Delito_de_Justicia.Detalle_de_Delito_de_Justicia_Asignar_Dueno> Get_Asignar_Dueno(string Key);


    }
}

