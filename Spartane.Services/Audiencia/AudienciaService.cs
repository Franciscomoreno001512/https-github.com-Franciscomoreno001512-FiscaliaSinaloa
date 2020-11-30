using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Audiencia;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Audiencia
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class AudienciaService : IAudienciaService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Audiencia.Audiencia> _AudienciaRepository;
        #endregion

        #region Ctor
        public AudienciaService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Audiencia.Audiencia> AudienciaRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._AudienciaRepository = AudienciaRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Audiencia.Audiencia> SelAll(bool ConRelaciones)
        {
            return this._AudienciaRepository.Table.ToList();
        }

        public IList<Core.Domain.Audiencia.Audiencia> SelAllComplete(bool ConRelaciones)
        {
            return this._AudienciaRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Audiencia.Audiencia> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._AudienciaRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Audiencia.Audiencia> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._AudienciaRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Audiencia.Audiencia> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._AudienciaRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Audiencia.AudienciaPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            AudienciaPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Audiencia.Audiencia> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._AudienciaRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Audiencia.Audiencia GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Audiencia.Audiencia result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData AudienciaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Audiencia.Audiencia entity, Spartane.Core.Domain.User.GlobalData AudienciaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Audiencia.Audiencia entity, Spartane.Core.Domain.User.GlobalData AudienciaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

