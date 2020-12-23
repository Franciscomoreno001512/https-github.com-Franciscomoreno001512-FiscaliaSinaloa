using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Detalle_de_Huellas_Digitales;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Detalle_de_Huellas_Digitales
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Detalle_de_Huellas_DigitalesService : IDetalle_de_Huellas_DigitalesService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Detalle_de_Huellas_Digitales.Detalle_de_Huellas_Digitales> _Detalle_de_Huellas_DigitalesRepository;
        #endregion

        #region Ctor
        public Detalle_de_Huellas_DigitalesService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Detalle_de_Huellas_Digitales.Detalle_de_Huellas_Digitales> Detalle_de_Huellas_DigitalesRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Detalle_de_Huellas_DigitalesRepository = Detalle_de_Huellas_DigitalesRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Detalle_de_Huellas_Digitales.Detalle_de_Huellas_Digitales> SelAll(bool ConRelaciones)
        {
            return this._Detalle_de_Huellas_DigitalesRepository.Table.ToList();
        }

        public IList<Core.Domain.Detalle_de_Huellas_Digitales.Detalle_de_Huellas_Digitales> SelAllComplete(bool ConRelaciones)
        {
            return this._Detalle_de_Huellas_DigitalesRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Detalle_de_Huellas_Digitales.Detalle_de_Huellas_Digitales> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Detalle_de_Huellas_DigitalesRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Detalle_de_Huellas_Digitales.Detalle_de_Huellas_Digitales> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Detalle_de_Huellas_DigitalesRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Detalle_de_Huellas_Digitales.Detalle_de_Huellas_Digitales> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Detalle_de_Huellas_DigitalesRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Detalle_de_Huellas_Digitales.Detalle_de_Huellas_DigitalesPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Detalle_de_Huellas_DigitalesPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Detalle_de_Huellas_Digitales.Detalle_de_Huellas_Digitales> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Detalle_de_Huellas_DigitalesRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Detalle_de_Huellas_Digitales.Detalle_de_Huellas_Digitales GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Detalle_de_Huellas_Digitales.Detalle_de_Huellas_Digitales result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Detalle_de_Huellas_DigitalesInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Detalle_de_Huellas_Digitales.Detalle_de_Huellas_Digitales entity, Spartane.Core.Domain.User.GlobalData Detalle_de_Huellas_DigitalesInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Detalle_de_Huellas_Digitales.Detalle_de_Huellas_Digitales entity, Spartane.Core.Domain.User.GlobalData Detalle_de_Huellas_DigitalesInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

