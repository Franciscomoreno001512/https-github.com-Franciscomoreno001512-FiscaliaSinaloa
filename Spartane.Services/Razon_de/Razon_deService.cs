using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Razon_de;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Razon_de
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Razon_deService : IRazon_deService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Razon_de.Razon_de> _Razon_deRepository;
        #endregion

        #region Ctor
        public Razon_deService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Razon_de.Razon_de> Razon_deRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Razon_deRepository = Razon_deRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Razon_de.Razon_de> SelAll(bool ConRelaciones)
        {
            return this._Razon_deRepository.Table.ToList();
        }

        public IList<Core.Domain.Razon_de.Razon_de> SelAllComplete(bool ConRelaciones)
        {
            return this._Razon_deRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Razon_de.Razon_de> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Razon_deRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Razon_de.Razon_de> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Razon_deRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Razon_de.Razon_de> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Razon_deRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Razon_de.Razon_dePagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Razon_dePagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Razon_de.Razon_de> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Razon_deRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Razon_de.Razon_de GetByKey(short Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Razon_de.Razon_de result=null;
            return result;
        }

        public bool Delete(short Key, Spartane.Core.Domain.User.GlobalData Razon_deInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public short Insert(Spartane.Core.Domain.Razon_de.Razon_de entity, Spartane.Core.Domain.User.GlobalData Razon_deInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            short rta = Convert.ToInt16("0");
            return rta;
        }

        public short Update(Spartane.Core.Domain.Razon_de.Razon_de entity, Spartane.Core.Domain.User.GlobalData Razon_deInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            short rta = Convert.ToInt16("0");
            return rta;
        }
        #endregion
    }
}

