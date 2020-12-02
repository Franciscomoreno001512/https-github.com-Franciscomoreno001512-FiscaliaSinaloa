using System;
using Spartane.Core.Domain.Unidad_de_Medida_de_pirateria;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Unidad_de_Medida_de_pirateria
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IUnidad_de_Medida_de_pirateriaService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Unidad_de_Medida_de_pirateria.Unidad_de_Medida_de_pirateria> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Unidad_de_Medida_de_pirateria.Unidad_de_Medida_de_pirateria> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Unidad_de_Medida_de_pirateria.Unidad_de_Medida_de_pirateria> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Unidad_de_Medida_de_pirateria.Unidad_de_Medida_de_pirateria GetByKey(short Key, Boolean ConRelaciones);
        bool Delete(short Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int16 Insert(Spartane.Core.Domain.Unidad_de_Medida_de_pirateria.Unidad_de_Medida_de_pirateria entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int16 Update(Spartane.Core.Domain.Unidad_de_Medida_de_pirateria.Unidad_de_Medida_de_pirateria entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Unidad_de_Medida_de_pirateria.Unidad_de_Medida_de_pirateria> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Unidad_de_Medida_de_pirateria.Unidad_de_Medida_de_pirateria> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Unidad_de_Medida_de_pirateria.Unidad_de_Medida_de_pirateriaPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Unidad_de_Medida_de_pirateria.Unidad_de_Medida_de_pirateria> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
