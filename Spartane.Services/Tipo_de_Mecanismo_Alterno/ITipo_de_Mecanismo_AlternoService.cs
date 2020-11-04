using System;
using Spartane.Core.Domain.Tipo_de_Mecanismo_Alterno;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Tipo_de_Mecanismo_Alterno
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface ITipo_de_Mecanismo_AlternoService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Tipo_de_Mecanismo_Alterno.Tipo_de_Mecanismo_Alterno> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Tipo_de_Mecanismo_Alterno.Tipo_de_Mecanismo_Alterno> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Tipo_de_Mecanismo_Alterno.Tipo_de_Mecanismo_Alterno> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Tipo_de_Mecanismo_Alterno.Tipo_de_Mecanismo_Alterno GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Tipo_de_Mecanismo_Alterno.Tipo_de_Mecanismo_Alterno entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Tipo_de_Mecanismo_Alterno.Tipo_de_Mecanismo_Alterno entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Tipo_de_Mecanismo_Alterno.Tipo_de_Mecanismo_Alterno> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Tipo_de_Mecanismo_Alterno.Tipo_de_Mecanismo_Alterno> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Tipo_de_Mecanismo_Alterno.Tipo_de_Mecanismo_AlternoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Tipo_de_Mecanismo_Alterno.Tipo_de_Mecanismo_Alterno> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
