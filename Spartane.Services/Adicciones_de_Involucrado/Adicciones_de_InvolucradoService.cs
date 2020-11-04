using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Adicciones_de_Involucrado;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Adicciones_de_Involucrado
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Adicciones_de_InvolucradoService : IAdicciones_de_InvolucradoService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Adicciones_de_Involucrado.Adicciones_de_Involucrado> _Adicciones_de_InvolucradoRepository;
        #endregion

        #region Ctor
        public Adicciones_de_InvolucradoService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Adicciones_de_Involucrado.Adicciones_de_Involucrado> Adicciones_de_InvolucradoRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Adicciones_de_InvolucradoRepository = Adicciones_de_InvolucradoRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Adicciones_de_Involucrado.Adicciones_de_Involucrado> SelAll(bool ConRelaciones)
        {
            return this._Adicciones_de_InvolucradoRepository.Table.ToList();
        }

        public IList<Core.Domain.Adicciones_de_Involucrado.Adicciones_de_Involucrado> SelAllComplete(bool ConRelaciones)
        {
            return this._Adicciones_de_InvolucradoRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Adicciones_de_Involucrado.Adicciones_de_Involucrado> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Adicciones_de_InvolucradoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Adicciones_de_Involucrado.Adicciones_de_Involucrado> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Adicciones_de_InvolucradoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Adicciones_de_Involucrado.Adicciones_de_Involucrado> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Adicciones_de_InvolucradoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Adicciones_de_Involucrado.Adicciones_de_InvolucradoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Adicciones_de_InvolucradoPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Adicciones_de_Involucrado.Adicciones_de_Involucrado> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Adicciones_de_InvolucradoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Adicciones_de_Involucrado.Adicciones_de_Involucrado GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Adicciones_de_Involucrado.Adicciones_de_Involucrado result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Adicciones_de_InvolucradoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Adicciones_de_Involucrado.Adicciones_de_Involucrado entity, Spartane.Core.Domain.User.GlobalData Adicciones_de_InvolucradoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Adicciones_de_Involucrado.Adicciones_de_Involucrado entity, Spartane.Core.Domain.User.GlobalData Adicciones_de_InvolucradoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

