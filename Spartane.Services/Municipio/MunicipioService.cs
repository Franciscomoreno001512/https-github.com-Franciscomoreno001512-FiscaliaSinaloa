using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Municipio;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Municipio
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class MunicipioService : IMunicipioService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Municipio.Municipio> _MunicipioRepository;
        #endregion

        #region Ctor
        public MunicipioService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Municipio.Municipio> MunicipioRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._MunicipioRepository = MunicipioRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Municipio.Municipio> SelAll(bool ConRelaciones)
        {
            return this._MunicipioRepository.Table.ToList();
        }

        public IList<Core.Domain.Municipio.Municipio> SelAllComplete(bool ConRelaciones)
        {
            return this._MunicipioRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Municipio.Municipio> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._MunicipioRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Municipio.Municipio> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._MunicipioRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Municipio.Municipio> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._MunicipioRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Municipio.MunicipioPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            MunicipioPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Municipio.Municipio> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._MunicipioRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Municipio.Municipio GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Municipio.Municipio result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData MunicipioInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Municipio.Municipio entity, Spartane.Core.Domain.User.GlobalData MunicipioInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Municipio.Municipio entity, Spartane.Core.Domain.User.GlobalData MunicipioInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

