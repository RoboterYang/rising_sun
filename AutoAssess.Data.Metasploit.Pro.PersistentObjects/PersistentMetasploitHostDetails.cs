using System;
using AutoAssess.Data.Metasploit.Pro.BusinessObjects;

namespace AutoAssess.Data.Metasploit.Pro.PersistentObjects
{
	[Serializable]
	public class PersistentMetasploitHostDetails : MetasploitHostDetail
	{
		public PersistentMetasploitHostDetails ()
		{
		}
		
		public PersistentMetasploitHostDetails(MetasploitHostDetail deets)
		{
			this.RemoteID = deets.RemoteID;
			this.RemoteHostID = deets.RemoteHostID;
			this.NexposeConsoleID = deets.NexposeConsoleID;
			this.NexposeDeviceID = deets.NexposeDeviceID;
			this.Source = deets.Source;
			this.NexposeSiteName = deets.NexposeSiteName;
			this.NexposeSiteImportance = deets.NexposeSiteImportance;
			this.NexposeScanTemplate = deets.NexposeScanTemplate;
			this.NexposeRiskScore = deets.NexposeRiskScore;
		}
		
		public virtual Guid ID { get; set; }
		
		public virtual Guid CreatedBy { get; set; }
		
		public virtual DateTime CreatedOn { get; set; }
		
		public virtual DateTime LastModifiedOn { get; set; }
		
		public virtual Guid LastModifiedBy { get; set; }
		
		public virtual bool IsActive { get; set; }
		
		public virtual void SetCreationInfo(Guid owner)
		{
			DateTime now = DateTime.Now;
			
			this.ID = Guid.NewGuid();
			this.CreatedBy = owner;
			this.CreatedOn = now;
			this.LastModifiedBy = owner;
			this.LastModifiedOn = now;
			this.IsActive = true;
		}
		
		public virtual void SetUpdateInfo(Guid modifier)
		{
			this.LastModifiedBy = modifier;
			this.LastModifiedOn = DateTime.Now;
		}
	}
}

