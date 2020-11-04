using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Control_de_Documentos
{
    public interface IControl_de_DocumentosApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Control_de_Documentos.Control_de_Documentos>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Control_de_Documentos.Control_de_Documentos>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Control_de_Documentos.Control_de_Documentos> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Control_de_Documentos.Control_de_DocumentosPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Control_de_DocumentosInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Control_de_Documentos.Control_de_Documentos entity, Spartane.Core.Domain.User.GlobalData Control_de_DocumentosInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Control_de_Documentos.Control_de_Documentos entity, Spartane.Core.Domain.User.GlobalData Control_de_DocumentosInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Control_de_Documentos.Control_de_Documentos>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Control_de_Documentos.Control_de_Documentos>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Control_de_Documentos.Control_de_Documentos>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Control_de_Documentos.Control_de_DocumentosPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Control_de_Documentos.Control_de_Documentos>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Control_de_Documentos.Control_de_Documentos_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Control_de_Documentos.Control_de_Documentos_Datos_Generales> Get_Datos_Generales(string Key);

		ApiResponse<int> Update_Documento(Spartane.Core.Domain.Control_de_Documentos.Control_de_Documentos_Documento entity);
		ApiResponse<Spartane.Core.Domain.Control_de_Documentos.Control_de_Documentos_Documento> Get_Documento(string Key);

		ApiResponse<int> Update_Secciones(Spartane.Core.Domain.Control_de_Documentos.Control_de_Documentos_Secciones entity);
		ApiResponse<Spartane.Core.Domain.Control_de_Documentos.Control_de_Documentos_Secciones> Get_Secciones(string Key);

		ApiResponse<int> Update_Historial(Spartane.Core.Domain.Control_de_Documentos.Control_de_Documentos_Historial entity);
		ApiResponse<Spartane.Core.Domain.Control_de_Documentos.Control_de_Documentos_Historial> Get_Historial(string Key);


    }
}

