using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Detalle_del_Indicio;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Detalle_del_Indicio
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Detalle_del_IndicioService : IDetalle_del_IndicioService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Detalle_del_Indicio.Detalle_del_Indicio> _Detalle_del_IndicioRepository;
        #endregion

        #region Ctor
        public Detalle_del_IndicioService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Detalle_del_Indicio.Detalle_del_Indicio> Detalle_del_IndicioRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Detalle_del_IndicioRepository = Detalle_del_IndicioRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Detalle_del_Indicio.Detalle_del_Indicio> SelAll(bool ConRelaciones)
        {
            return this._Detalle_del_IndicioRepository.Table.ToList();
        }

        public IList<Core.Domain.Detalle_del_Indicio.Detalle_del_Indicio> SelAllComplete(bool ConRelaciones)
        {
            return this._Detalle_del_IndicioRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Detalle_del_Indicio.Detalle_del_Indicio> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Detalle_del_IndicioRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Detalle_del_Indicio.Detalle_del_Indicio> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Detalle_del_IndicioRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Detalle_del_Indicio.Detalle_del_Indicio> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Detalle_del_IndicioRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Detalle_del_Indicio.Detalle_del_IndicioPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Detalle_del_IndicioPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Detalle_del_Indicio.Detalle_del_Indicio> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Detalle_del_IndicioRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Detalle_del_Indicio.Detalle_del_Indicio GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Detalle_del_Indicio.Detalle_del_Indicio result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Detalle_del_IndicioInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Detalle_del_Indicio.Detalle_del_Indicio entity, Spartane.Core.Domain.User.GlobalData Detalle_del_IndicioInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Detalle_del_Indicio.Detalle_del_Indicio entity, Spartane.Core.Domain.User.GlobalData Detalle_del_IndicioInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

