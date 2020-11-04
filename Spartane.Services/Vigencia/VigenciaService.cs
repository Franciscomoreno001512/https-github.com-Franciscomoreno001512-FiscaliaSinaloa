using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Vigencia;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Vigencia
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class VigenciaService : IVigenciaService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Vigencia.Vigencia> _VigenciaRepository;
        #endregion

        #region Ctor
        public VigenciaService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Vigencia.Vigencia> VigenciaRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._VigenciaRepository = VigenciaRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Vigencia.Vigencia> SelAll(bool ConRelaciones)
        {
            return this._VigenciaRepository.Table.ToList();
        }

        public IList<Core.Domain.Vigencia.Vigencia> SelAllComplete(bool ConRelaciones)
        {
            return this._VigenciaRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Vigencia.Vigencia> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._VigenciaRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Vigencia.Vigencia> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._VigenciaRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Vigencia.Vigencia> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._VigenciaRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Vigencia.VigenciaPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            VigenciaPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Vigencia.Vigencia> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._VigenciaRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Vigencia.Vigencia GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Vigencia.Vigencia result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData VigenciaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Vigencia.Vigencia entity, Spartane.Core.Domain.User.GlobalData VigenciaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Vigencia.Vigencia entity, Spartane.Core.Domain.User.GlobalData VigenciaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

