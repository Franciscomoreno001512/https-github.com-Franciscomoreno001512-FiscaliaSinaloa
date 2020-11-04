using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Abogado;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Abogado
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class AbogadoService : IAbogadoService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Abogado.Abogado> _AbogadoRepository;
        #endregion

        #region Ctor
        public AbogadoService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Abogado.Abogado> AbogadoRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._AbogadoRepository = AbogadoRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Abogado.Abogado> SelAll(bool ConRelaciones)
        {
            return this._AbogadoRepository.Table.ToList();
        }

        public IList<Core.Domain.Abogado.Abogado> SelAllComplete(bool ConRelaciones)
        {
            return this._AbogadoRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Abogado.Abogado> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._AbogadoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Abogado.Abogado> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._AbogadoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Abogado.Abogado> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._AbogadoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Abogado.AbogadoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            AbogadoPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Abogado.Abogado> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._AbogadoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Abogado.Abogado GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Abogado.Abogado result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData AbogadoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Abogado.Abogado entity, Spartane.Core.Domain.User.GlobalData AbogadoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Abogado.Abogado entity, Spartane.Core.Domain.User.GlobalData AbogadoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

