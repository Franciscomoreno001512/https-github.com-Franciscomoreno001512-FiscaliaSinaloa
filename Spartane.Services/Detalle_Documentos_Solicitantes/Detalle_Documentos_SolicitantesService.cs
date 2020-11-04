using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Detalle_Documentos_Solicitantes;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Detalle_Documentos_Solicitantes
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Detalle_Documentos_SolicitantesService : IDetalle_Documentos_SolicitantesService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Detalle_Documentos_Solicitantes.Detalle_Documentos_Solicitantes> _Detalle_Documentos_SolicitantesRepository;
        #endregion

        #region Ctor
        public Detalle_Documentos_SolicitantesService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Detalle_Documentos_Solicitantes.Detalle_Documentos_Solicitantes> Detalle_Documentos_SolicitantesRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Detalle_Documentos_SolicitantesRepository = Detalle_Documentos_SolicitantesRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Detalle_Documentos_Solicitantes.Detalle_Documentos_Solicitantes> SelAll(bool ConRelaciones)
        {
            return this._Detalle_Documentos_SolicitantesRepository.Table.ToList();
        }

        public IList<Core.Domain.Detalle_Documentos_Solicitantes.Detalle_Documentos_Solicitantes> SelAllComplete(bool ConRelaciones)
        {
            return this._Detalle_Documentos_SolicitantesRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Detalle_Documentos_Solicitantes.Detalle_Documentos_Solicitantes> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Detalle_Documentos_SolicitantesRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Detalle_Documentos_Solicitantes.Detalle_Documentos_Solicitantes> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Detalle_Documentos_SolicitantesRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Detalle_Documentos_Solicitantes.Detalle_Documentos_Solicitantes> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Detalle_Documentos_SolicitantesRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Detalle_Documentos_Solicitantes.Detalle_Documentos_SolicitantesPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Detalle_Documentos_SolicitantesPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Detalle_Documentos_Solicitantes.Detalle_Documentos_Solicitantes> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Detalle_Documentos_SolicitantesRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Detalle_Documentos_Solicitantes.Detalle_Documentos_Solicitantes GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Detalle_Documentos_Solicitantes.Detalle_Documentos_Solicitantes result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Detalle_Documentos_SolicitantesInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Detalle_Documentos_Solicitantes.Detalle_Documentos_Solicitantes entity, Spartane.Core.Domain.User.GlobalData Detalle_Documentos_SolicitantesInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Detalle_Documentos_Solicitantes.Detalle_Documentos_Solicitantes entity, Spartane.Core.Domain.User.GlobalData Detalle_Documentos_SolicitantesInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

