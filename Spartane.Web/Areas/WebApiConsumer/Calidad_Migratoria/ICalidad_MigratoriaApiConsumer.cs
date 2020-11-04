using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Calidad_Migratoria
{
    public interface ICalidad_MigratoriaApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Calidad_Migratoria.Calidad_Migratoria>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Calidad_Migratoria.Calidad_Migratoria>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Calidad_Migratoria.Calidad_Migratoria> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Calidad_Migratoria.Calidad_MigratoriaPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Calidad_MigratoriaInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Calidad_Migratoria.Calidad_Migratoria entity, Spartane.Core.Domain.User.GlobalData Calidad_MigratoriaInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Calidad_Migratoria.Calidad_Migratoria entity, Spartane.Core.Domain.User.GlobalData Calidad_MigratoriaInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Calidad_Migratoria.Calidad_Migratoria>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Calidad_Migratoria.Calidad_Migratoria>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Calidad_Migratoria.Calidad_Migratoria>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Calidad_Migratoria.Calidad_MigratoriaPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Calidad_Migratoria.Calidad_Migratoria>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Calidad_Migratoria.Calidad_Migratoria_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Calidad_Migratoria.Calidad_Migratoria_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

