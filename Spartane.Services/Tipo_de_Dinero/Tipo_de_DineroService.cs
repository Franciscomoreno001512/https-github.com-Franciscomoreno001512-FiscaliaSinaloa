using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Tipo_de_Dinero;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Tipo_de_Dinero
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Tipo_de_DineroService : ITipo_de_DineroService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Tipo_de_Dinero.Tipo_de_Dinero> _Tipo_de_DineroRepository;
        #endregion

        #region Ctor
        public Tipo_de_DineroService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Tipo_de_Dinero.Tipo_de_Dinero> Tipo_de_DineroRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Tipo_de_DineroRepository = Tipo_de_DineroRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Tipo_de_Dinero.Tipo_de_Dinero> SelAll(bool ConRelaciones)
        {
            return this._Tipo_de_DineroRepository.Table.ToList();
        }

        public IList<Core.Domain.Tipo_de_Dinero.Tipo_de_Dinero> SelAllComplete(bool ConRelaciones)
        {
            return this._Tipo_de_DineroRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Tipo_de_Dinero.Tipo_de_Dinero> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Tipo_de_DineroRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Tipo_de_Dinero.Tipo_de_Dinero> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Tipo_de_DineroRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Tipo_de_Dinero.Tipo_de_Dinero> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Tipo_de_DineroRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Tipo_de_Dinero.Tipo_de_DineroPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Tipo_de_DineroPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Tipo_de_Dinero.Tipo_de_Dinero> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Tipo_de_DineroRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Tipo_de_Dinero.Tipo_de_Dinero GetByKey(short Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Tipo_de_Dinero.Tipo_de_Dinero result=null;
            return result;
        }

        public bool Delete(short Key, Spartane.Core.Domain.User.GlobalData Tipo_de_DineroInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public short Insert(Spartane.Core.Domain.Tipo_de_Dinero.Tipo_de_Dinero entity, Spartane.Core.Domain.User.GlobalData Tipo_de_DineroInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            short rta = Convert.ToInt16("0");
            return rta;
        }

        public short Update(Spartane.Core.Domain.Tipo_de_Dinero.Tipo_de_Dinero entity, Spartane.Core.Domain.User.GlobalData Tipo_de_DineroInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            short rta = Convert.ToInt16("0");
            return rta;
        }
        #endregion
    }
}

