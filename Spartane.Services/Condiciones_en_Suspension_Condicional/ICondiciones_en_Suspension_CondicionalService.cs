using System;
using Spartane.Core.Domain.Condiciones_en_Suspension_Condicional;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Condiciones_en_Suspension_Condicional
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface ICondiciones_en_Suspension_CondicionalService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Condiciones_en_Suspension_Condicional.Condiciones_en_Suspension_Condicional> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Condiciones_en_Suspension_Condicional.Condiciones_en_Suspension_Condicional> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Condiciones_en_Suspension_Condicional.Condiciones_en_Suspension_Condicional> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Condiciones_en_Suspension_Condicional.Condiciones_en_Suspension_Condicional GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Condiciones_en_Suspension_Condicional.Condiciones_en_Suspension_Condicional entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Condiciones_en_Suspension_Condicional.Condiciones_en_Suspension_Condicional entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Condiciones_en_Suspension_Condicional.Condiciones_en_Suspension_Condicional> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Condiciones_en_Suspension_Condicional.Condiciones_en_Suspension_Condicional> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Condiciones_en_Suspension_Condicional.Condiciones_en_Suspension_CondicionalPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Condiciones_en_Suspension_Condicional.Condiciones_en_Suspension_Condicional> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
