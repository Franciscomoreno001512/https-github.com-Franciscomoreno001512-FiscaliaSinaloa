using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Formato_de_Seguimiento;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Formato_de_Seguimiento
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Formato_de_SeguimientoService : IFormato_de_SeguimientoService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Formato_de_Seguimiento.Formato_de_Seguimiento> _Formato_de_SeguimientoRepository;
        #endregion

        #region Ctor
        public Formato_de_SeguimientoService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Formato_de_Seguimiento.Formato_de_Seguimiento> Formato_de_SeguimientoRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Formato_de_SeguimientoRepository = Formato_de_SeguimientoRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Formato_de_Seguimiento.Formato_de_Seguimiento> SelAll(bool ConRelaciones)
        {
            return this._Formato_de_SeguimientoRepository.Table.ToList();
        }

        public IList<Core.Domain.Formato_de_Seguimiento.Formato_de_Seguimiento> SelAllComplete(bool ConRelaciones)
        {
            return this._Formato_de_SeguimientoRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Formato_de_Seguimiento.Formato_de_Seguimiento> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Formato_de_SeguimientoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Formato_de_Seguimiento.Formato_de_Seguimiento> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Formato_de_SeguimientoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Formato_de_Seguimiento.Formato_de_Seguimiento> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Formato_de_SeguimientoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Formato_de_Seguimiento.Formato_de_SeguimientoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Formato_de_SeguimientoPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Formato_de_Seguimiento.Formato_de_Seguimiento> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Formato_de_SeguimientoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Formato_de_Seguimiento.Formato_de_Seguimiento GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Formato_de_Seguimiento.Formato_de_Seguimiento result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Formato_de_SeguimientoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Formato_de_Seguimiento.Formato_de_Seguimiento entity, Spartane.Core.Domain.User.GlobalData Formato_de_SeguimientoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Formato_de_Seguimiento.Formato_de_Seguimiento entity, Spartane.Core.Domain.User.GlobalData Formato_de_SeguimientoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

