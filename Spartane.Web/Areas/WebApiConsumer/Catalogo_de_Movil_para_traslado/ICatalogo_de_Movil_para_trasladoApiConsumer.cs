using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Catalogo_de_Movil_para_traslado
{
    public interface ICatalogo_de_Movil_para_trasladoApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Catalogo_de_Movil_para_traslado.Catalogo_de_Movil_para_traslado>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Catalogo_de_Movil_para_traslado.Catalogo_de_Movil_para_traslado>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Catalogo_de_Movil_para_traslado.Catalogo_de_Movil_para_traslado> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Catalogo_de_Movil_para_traslado.Catalogo_de_Movil_para_trasladoPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Catalogo_de_Movil_para_trasladoInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Catalogo_de_Movil_para_traslado.Catalogo_de_Movil_para_traslado entity, Spartane.Core.Domain.User.GlobalData Catalogo_de_Movil_para_trasladoInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Catalogo_de_Movil_para_traslado.Catalogo_de_Movil_para_traslado entity, Spartane.Core.Domain.User.GlobalData Catalogo_de_Movil_para_trasladoInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Catalogo_de_Movil_para_traslado.Catalogo_de_Movil_para_traslado>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Catalogo_de_Movil_para_traslado.Catalogo_de_Movil_para_traslado>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Catalogo_de_Movil_para_traslado.Catalogo_de_Movil_para_traslado>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Catalogo_de_Movil_para_traslado.Catalogo_de_Movil_para_trasladoPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Catalogo_de_Movil_para_traslado.Catalogo_de_Movil_para_traslado>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Catalogo_de_Movil_para_traslado.Catalogo_de_Movil_para_traslado_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Catalogo_de_Movil_para_traslado.Catalogo_de_Movil_para_traslado_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

