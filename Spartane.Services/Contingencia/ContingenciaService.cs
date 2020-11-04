using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Contingencia;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Contingencia
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class ContingenciaService : IContingenciaService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Contingencia.Contingencia> _ContingenciaRepository;
        #endregion

        #region Ctor
        public ContingenciaService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Contingencia.Contingencia> ContingenciaRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._ContingenciaRepository = ContingenciaRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Contingencia.Contingencia> SelAll(bool ConRelaciones)
        {
            return this._ContingenciaRepository.Table.ToList();
        }

        public IList<Core.Domain.Contingencia.Contingencia> SelAllComplete(bool ConRelaciones)
        {
            return this._ContingenciaRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Contingencia.Contingencia> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._ContingenciaRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Contingencia.Contingencia> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._ContingenciaRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Contingencia.Contingencia> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._ContingenciaRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Contingencia.ContingenciaPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            ContingenciaPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Contingencia.Contingencia> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._ContingenciaRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Contingencia.Contingencia GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Contingencia.Contingencia result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData ContingenciaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Contingencia.Contingencia entity, Spartane.Core.Domain.User.GlobalData ContingenciaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Contingencia.Contingencia entity, Spartane.Core.Domain.User.GlobalData ContingenciaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

