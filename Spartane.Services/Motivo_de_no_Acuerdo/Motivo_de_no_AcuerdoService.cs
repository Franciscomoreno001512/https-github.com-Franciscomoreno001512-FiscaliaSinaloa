using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Motivo_de_no_Acuerdo;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Motivo_de_no_Acuerdo
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Motivo_de_no_AcuerdoService : IMotivo_de_no_AcuerdoService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Motivo_de_no_Acuerdo.Motivo_de_no_Acuerdo> _Motivo_de_no_AcuerdoRepository;
        #endregion

        #region Ctor
        public Motivo_de_no_AcuerdoService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Motivo_de_no_Acuerdo.Motivo_de_no_Acuerdo> Motivo_de_no_AcuerdoRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Motivo_de_no_AcuerdoRepository = Motivo_de_no_AcuerdoRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Motivo_de_no_Acuerdo.Motivo_de_no_Acuerdo> SelAll(bool ConRelaciones)
        {
            return this._Motivo_de_no_AcuerdoRepository.Table.ToList();
        }

        public IList<Core.Domain.Motivo_de_no_Acuerdo.Motivo_de_no_Acuerdo> SelAllComplete(bool ConRelaciones)
        {
            return this._Motivo_de_no_AcuerdoRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Motivo_de_no_Acuerdo.Motivo_de_no_Acuerdo> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Motivo_de_no_AcuerdoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Motivo_de_no_Acuerdo.Motivo_de_no_Acuerdo> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Motivo_de_no_AcuerdoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Motivo_de_no_Acuerdo.Motivo_de_no_Acuerdo> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Motivo_de_no_AcuerdoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Motivo_de_no_Acuerdo.Motivo_de_no_AcuerdoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Motivo_de_no_AcuerdoPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Motivo_de_no_Acuerdo.Motivo_de_no_Acuerdo> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Motivo_de_no_AcuerdoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Motivo_de_no_Acuerdo.Motivo_de_no_Acuerdo GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Motivo_de_no_Acuerdo.Motivo_de_no_Acuerdo result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Motivo_de_no_AcuerdoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Motivo_de_no_Acuerdo.Motivo_de_no_Acuerdo entity, Spartane.Core.Domain.User.GlobalData Motivo_de_no_AcuerdoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Motivo_de_no_Acuerdo.Motivo_de_no_Acuerdo entity, Spartane.Core.Domain.User.GlobalData Motivo_de_no_AcuerdoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

