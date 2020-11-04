using System;
using Spartane.Core.Domain.Especialista_de_Justicia_Alternativa;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Especialista_de_Justicia_Alternativa
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IEspecialista_de_Justicia_AlternativaService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Especialista_de_Justicia_Alternativa.Especialista_de_Justicia_Alternativa> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Especialista_de_Justicia_Alternativa.Especialista_de_Justicia_Alternativa> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Especialista_de_Justicia_Alternativa.Especialista_de_Justicia_Alternativa> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Especialista_de_Justicia_Alternativa.Especialista_de_Justicia_Alternativa GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Especialista_de_Justicia_Alternativa.Especialista_de_Justicia_Alternativa entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Especialista_de_Justicia_Alternativa.Especialista_de_Justicia_Alternativa entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Especialista_de_Justicia_Alternativa.Especialista_de_Justicia_Alternativa> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Especialista_de_Justicia_Alternativa.Especialista_de_Justicia_Alternativa> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Especialista_de_Justicia_Alternativa.Especialista_de_Justicia_AlternativaPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Especialista_de_Justicia_Alternativa.Especialista_de_Justicia_Alternativa> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
