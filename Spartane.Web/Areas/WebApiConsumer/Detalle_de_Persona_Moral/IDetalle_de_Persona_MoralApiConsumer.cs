using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Detalle_de_Persona_Moral
{
    public interface IDetalle_de_Persona_MoralApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Detalle_de_Persona_Moral.Detalle_de_Persona_Moral>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Detalle_de_Persona_Moral.Detalle_de_Persona_Moral>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Detalle_de_Persona_Moral.Detalle_de_Persona_Moral> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Detalle_de_Persona_Moral.Detalle_de_Persona_MoralPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Detalle_de_Persona_MoralInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Detalle_de_Persona_Moral.Detalle_de_Persona_Moral entity, Spartane.Core.Domain.User.GlobalData Detalle_de_Persona_MoralInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Detalle_de_Persona_Moral.Detalle_de_Persona_Moral entity, Spartane.Core.Domain.User.GlobalData Detalle_de_Persona_MoralInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Detalle_de_Persona_Moral.Detalle_de_Persona_Moral>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Detalle_de_Persona_Moral.Detalle_de_Persona_Moral>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Detalle_de_Persona_Moral.Detalle_de_Persona_Moral>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Detalle_de_Persona_Moral.Detalle_de_Persona_MoralPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Detalle_de_Persona_Moral.Detalle_de_Persona_Moral>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Detalle_de_Persona_Moral.Detalle_de_Persona_Moral_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Detalle_de_Persona_Moral.Detalle_de_Persona_Moral_Datos_Generales> Get_Datos_Generales(string Key);

		ApiResponse<int> Update_Representante_Legal(Spartane.Core.Domain.Detalle_de_Persona_Moral.Detalle_de_Persona_Moral_Representante_Legal entity);
		ApiResponse<Spartane.Core.Domain.Detalle_de_Persona_Moral.Detalle_de_Persona_Moral_Representante_Legal> Get_Representante_Legal(string Key);


    }
}

