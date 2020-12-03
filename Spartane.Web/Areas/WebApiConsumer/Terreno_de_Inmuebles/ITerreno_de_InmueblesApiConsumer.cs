using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Terreno_de_Inmuebles
{
    public interface ITerreno_de_InmueblesApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Terreno_de_Inmuebles.Terreno_de_Inmuebles>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Terreno_de_Inmuebles.Terreno_de_Inmuebles>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Terreno_de_Inmuebles.Terreno_de_Inmuebles> GetByKey(short Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Terreno_de_Inmuebles.Terreno_de_InmueblesPagingModel> GetByKeyComplete(short Key);
        ApiResponse<bool> Delete(short Key, Spartane.Core.Domain.User.GlobalData Terreno_de_InmueblesInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int16> Insert(Spartane.Core.Domain.Terreno_de_Inmuebles.Terreno_de_Inmuebles entity, Spartane.Core.Domain.User.GlobalData Terreno_de_InmueblesInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int16> Update(Spartane.Core.Domain.Terreno_de_Inmuebles.Terreno_de_Inmuebles entity, Spartane.Core.Domain.User.GlobalData Terreno_de_InmueblesInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Terreno_de_Inmuebles.Terreno_de_Inmuebles>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Terreno_de_Inmuebles.Terreno_de_Inmuebles>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Terreno_de_Inmuebles.Terreno_de_Inmuebles>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Terreno_de_Inmuebles.Terreno_de_InmueblesPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Terreno_de_Inmuebles.Terreno_de_Inmuebles>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<short> GenerateID();
		ApiResponse<short> Update_Datos_Generales(Spartane.Core.Domain.Terreno_de_Inmuebles.Terreno_de_Inmuebles_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Terreno_de_Inmuebles.Terreno_de_Inmuebles_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

