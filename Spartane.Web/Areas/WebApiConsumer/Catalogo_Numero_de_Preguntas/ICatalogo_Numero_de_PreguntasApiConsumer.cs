using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Catalogo_Numero_de_Preguntas
{
    public interface ICatalogo_Numero_de_PreguntasApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Catalogo_Numero_de_Preguntas.Catalogo_Numero_de_Preguntas>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Catalogo_Numero_de_Preguntas.Catalogo_Numero_de_Preguntas>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Catalogo_Numero_de_Preguntas.Catalogo_Numero_de_Preguntas> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Catalogo_Numero_de_Preguntas.Catalogo_Numero_de_PreguntasPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Catalogo_Numero_de_PreguntasInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Catalogo_Numero_de_Preguntas.Catalogo_Numero_de_Preguntas entity, Spartane.Core.Domain.User.GlobalData Catalogo_Numero_de_PreguntasInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Catalogo_Numero_de_Preguntas.Catalogo_Numero_de_Preguntas entity, Spartane.Core.Domain.User.GlobalData Catalogo_Numero_de_PreguntasInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Catalogo_Numero_de_Preguntas.Catalogo_Numero_de_Preguntas>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Catalogo_Numero_de_Preguntas.Catalogo_Numero_de_Preguntas>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Catalogo_Numero_de_Preguntas.Catalogo_Numero_de_Preguntas>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Catalogo_Numero_de_Preguntas.Catalogo_Numero_de_PreguntasPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Catalogo_Numero_de_Preguntas.Catalogo_Numero_de_Preguntas>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Catalogo_Numero_de_Preguntas.Catalogo_Numero_de_Preguntas_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Catalogo_Numero_de_Preguntas.Catalogo_Numero_de_Preguntas_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

