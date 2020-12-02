using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Unidad_de_Medida_de_pirateria
{
    public interface IUnidad_de_Medida_de_pirateriaApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Unidad_de_Medida_de_pirateria.Unidad_de_Medida_de_pirateria>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Unidad_de_Medida_de_pirateria.Unidad_de_Medida_de_pirateria>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Unidad_de_Medida_de_pirateria.Unidad_de_Medida_de_pirateria> GetByKey(short Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Unidad_de_Medida_de_pirateria.Unidad_de_Medida_de_pirateriaPagingModel> GetByKeyComplete(short Key);
        ApiResponse<bool> Delete(short Key, Spartane.Core.Domain.User.GlobalData Unidad_de_Medida_de_pirateriaInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int16> Insert(Spartane.Core.Domain.Unidad_de_Medida_de_pirateria.Unidad_de_Medida_de_pirateria entity, Spartane.Core.Domain.User.GlobalData Unidad_de_Medida_de_pirateriaInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int16> Update(Spartane.Core.Domain.Unidad_de_Medida_de_pirateria.Unidad_de_Medida_de_pirateria entity, Spartane.Core.Domain.User.GlobalData Unidad_de_Medida_de_pirateriaInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Unidad_de_Medida_de_pirateria.Unidad_de_Medida_de_pirateria>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Unidad_de_Medida_de_pirateria.Unidad_de_Medida_de_pirateria>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Unidad_de_Medida_de_pirateria.Unidad_de_Medida_de_pirateria>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Unidad_de_Medida_de_pirateria.Unidad_de_Medida_de_pirateriaPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Unidad_de_Medida_de_pirateria.Unidad_de_Medida_de_pirateria>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<short> GenerateID();
		ApiResponse<short> Update_Datos_Generales(Spartane.Core.Domain.Unidad_de_Medida_de_pirateria.Unidad_de_Medida_de_pirateria_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Unidad_de_Medida_de_pirateria.Unidad_de_Medida_de_pirateria_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

