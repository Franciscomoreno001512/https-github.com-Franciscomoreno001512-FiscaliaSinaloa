using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Modelo_de_equipo_tactico
{
    public interface IModelo_de_equipo_tacticoApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Modelo_de_equipo_tactico.Modelo_de_equipo_tactico>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Modelo_de_equipo_tactico.Modelo_de_equipo_tactico>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Modelo_de_equipo_tactico.Modelo_de_equipo_tactico> GetByKey(short Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Modelo_de_equipo_tactico.Modelo_de_equipo_tacticoPagingModel> GetByKeyComplete(short Key);
        ApiResponse<bool> Delete(short Key, Spartane.Core.Domain.User.GlobalData Modelo_de_equipo_tacticoInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int16> Insert(Spartane.Core.Domain.Modelo_de_equipo_tactico.Modelo_de_equipo_tactico entity, Spartane.Core.Domain.User.GlobalData Modelo_de_equipo_tacticoInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int16> Update(Spartane.Core.Domain.Modelo_de_equipo_tactico.Modelo_de_equipo_tactico entity, Spartane.Core.Domain.User.GlobalData Modelo_de_equipo_tacticoInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Modelo_de_equipo_tactico.Modelo_de_equipo_tactico>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Modelo_de_equipo_tactico.Modelo_de_equipo_tactico>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Modelo_de_equipo_tactico.Modelo_de_equipo_tactico>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Modelo_de_equipo_tactico.Modelo_de_equipo_tacticoPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Modelo_de_equipo_tactico.Modelo_de_equipo_tactico>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<short> GenerateID();
		ApiResponse<short> Update_Datos_Generales(Spartane.Core.Domain.Modelo_de_equipo_tactico.Modelo_de_equipo_tactico_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Modelo_de_equipo_tactico.Modelo_de_equipo_tactico_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

