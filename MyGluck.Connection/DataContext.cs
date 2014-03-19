using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using MyGluck.Domain;
using System.Data.Entity.ModelConfiguration.Conventions;
namespace MyGluck.Connection
{
	/// <summary>
	/// Autor: Israel Romero Ponce
	/// Comentarios: Clase de datos
	/// </summary>
	public class DataContext : DbContext
	{
		public DbSet<webpages_Role> webpages_Roles { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<Payment> Payments { get; set; }
		public DbSet<GiftTable> GiftTables { get; set; }
		public DbSet<Unit> Units { get; set; }
		public DbSet<Country> Countries { get; set; }
		public DbSet<State> States { get; set; }
		public DbSet<Provider> Providers { get; set; }
		public DbSet<Package> Packages { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<PackageProduct> PackageProducts { get; set; }
		public DbSet<InvitationSetting> InvitationSettings { get; set; }
		public DbSet<SiteConfiguration> SiteConfigurations { get; set; }
		public DbSet<GuestStatus> GuestStatus { get; set; }
		public DbSet<SectionType> SectionTypes { get; set; }
		public DbSet<Theme> Themes { get; set; }
		public DbSet<EventType> EventTypes { get; set; }
		public DbSet<UserProfile> UserProfile { get; set; }
		public DbSet<Event> Events { get; set; }
		public DbSet<Schedule> Schedules { get; set; }
		public DbSet<EventPhoto> EventPhotos { get; set; }
		public DbSet<WishList> WishList { get; set; }
		public DbSet<Sale> Sales { get; set; }
		public DbSet<Guest> Guests { get; set; }
		public DbSet<Section> Sections { get; set; }
		public DbSet<webpages_OAuthMembership> webpages_OAuthMembership { get; set; }
		public DbSet<webpages_Membership> webpages_Membership { get; set; }
		public DbSet<webpages_UsersInRole> webpages_UsersInRoles { get; set; }
	}
}
