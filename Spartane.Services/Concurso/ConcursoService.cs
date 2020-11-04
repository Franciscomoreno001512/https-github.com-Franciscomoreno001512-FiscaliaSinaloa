using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Concurso;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Concurso
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class ConcursoService : IConcursoService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Concurso.Concurso> _ConcursoRepository;
        #endregion

        #region Ctor
        public ConcursoService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Concurso.Concurso> ConcursoRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._ConcursoRepository = ConcursoRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Concurso.Concurso> SelAll(bool ConRelaciones)
        {
            return this._ConcursoRepository.Table.ToList();
        }

        public IList<Core.Domain.Concurso.Concurso> SelAllComplete(bool ConRelaciones)
        {
            return this._ConcursoRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Concurso.Concurso> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._ConcursoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Concurso.Concurso> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._ConcursoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Concurso.Concurso> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._ConcursoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Concurso.ConcursoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            ConcursoPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Concurso.Concurso> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._ConcursoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Concurso.Concurso GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Concurso.Concurso result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData ConcursoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Concurso.Concurso entity, Spartane.Core.Domain.User.GlobalData ConcursoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Concurso.Concurso entity, Spartane.Core.Domain.User.GlobalData ConcursoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

