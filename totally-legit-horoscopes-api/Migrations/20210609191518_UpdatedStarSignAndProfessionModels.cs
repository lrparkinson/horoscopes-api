using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace totally_legit_horoscopes_api.Migrations
{
    public partial class UpdatedStarSignAndProfessionModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Professions_ProfessionId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_StarSigns_StarSignId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_ProfessionId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_StarSignId",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StarSigns",
                table: "StarSigns");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Professions",
                table: "Professions");

            migrationBuilder.DropColumn(
                name: "ProfessionId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "StarSignId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "StarSignId",
                table: "StarSigns");

            migrationBuilder.DropColumn(
                name: "ProfessionId",
                table: "Professions");

            migrationBuilder.AddColumn<string>(
                name: "ProfessionName",
                table: "Users",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StarSignName",
                table: "Users",
                type: "text",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_StarSigns",
                table: "StarSigns",
                column: "Name");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Professions",
                table: "Professions",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_Users_ProfessionName",
                table: "Users",
                column: "ProfessionName");

            migrationBuilder.CreateIndex(
                name: "IX_Users_StarSignName",
                table: "Users",
                column: "StarSignName");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Professions_ProfessionName",
                table: "Users",
                column: "ProfessionName",
                principalTable: "Professions",
                principalColumn: "Name",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_StarSigns_StarSignName",
                table: "Users",
                column: "StarSignName",
                principalTable: "StarSigns",
                principalColumn: "Name",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Professions_ProfessionName",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_StarSigns_StarSignName",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_ProfessionName",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_StarSignName",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StarSigns",
                table: "StarSigns");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Professions",
                table: "Professions");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Accountant");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Accounts Assistant");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Accounts Clerk");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Accounts Manager");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Accounts Staff");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Acoustic Engineer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Actor");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Actress");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Actuary");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Acupuncturist");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Adjustor");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Administration Assistant");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Administration Clerk");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Administration Manager");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Administration Staff");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Administrator");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Advertising Agent");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Advertising Assistant");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Advertising Clerk");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Advertising Contractor");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Advertising Executive");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Advertising Manager");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Advertising Staff");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Aerial Erector");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Aerobic Instructor");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Aeronautical Engineer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Agent");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Air Traffic Controller");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Aircraft Designer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Aircraft Engineer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Aircraft Maintenance Engineer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Aircraft Surface Finisher");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Airman");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Airport Controller");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Airport Manager");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Almoner");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Ambulance Controller");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Ambulance Crew");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Ambulance Driver");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Amusement Arcade Worker");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Anaesthetist");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Analyst");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Analytical Chemist");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Animal Breeder");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Anthropologist");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Antique Dealer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Applications Engineer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Applications Programmer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Arbitrator");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Arborist");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Archaeologist");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Architect");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Archivist");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Area Manager");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Armourer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Aromatherapist");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Art Critic");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Art Dealer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Art Historian");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Art Restorer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Artexer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Artist");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Arts");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Assembly Worker");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Assessor");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Assistant");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Assistant Caretaker");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Assistant Cook");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Assistant Manager");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Assistant Nurse");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Assistant Teacher");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Astrologer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Astronomer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Attendant");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Au Pair");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Auction Worker");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Auctioneer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Audiologist");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Audit Clerk");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Audit Manager");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Auditor");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Auto Electrician");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Auxiliary Nurse");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Bacon Curer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Baggage Handler");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Bailiff");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Baker");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Bakery Assistant");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Bakery Manager");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Bakery Operator");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Balloonist");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Bank Clerk");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Bank Manager");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Bank Messenger");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Baptist Minister");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Bar Manager");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Bar Steward");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Barber");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Barmaid");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Barman");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Barrister");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Beautician");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Beauty Therapist");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Betting Shop");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Bill Poster");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Bingo Caller");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Biochemist");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Biologist");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Blacksmith");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Blind Assembler");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Blind Fitter");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Blinds Installer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Boat Builder");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Body Fitter");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Bodyguard");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Bodyshop");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Book Binder");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Book Seller");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Book-Keeper");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Booking Agent");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Booking Clerk");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Bookmaker");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Botanist");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Branch Manager");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Breeder");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Brewer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Brewery Manager");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Brewery Worker");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Bricklayer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Broadcaster");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Builder");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Builders Labourer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Building Advisor");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Building Control");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Building Engineer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Building Estimator");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Building Foreman");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Building Inspector");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Building Manager");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Building Surveyor");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Bursar");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Bus Company");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Bus Conductor");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Bus Driver");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Bus Mechanic");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Bus Valeter");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Business Consultant");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Business Proprietor");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Butcher");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Butchery Manager");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Butler");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Buyer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Cab Driver");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Cabinet Maker");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Cable Contractor");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Cable Jointer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Cable TV Installer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Cafe Owner");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Cafe Staff");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Cafe Worker");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Calibration Manager");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Camera Repairer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Cameraman");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Car Dealer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Car Delivery Driver");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Car Park Attendant");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Car Salesman");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Car Valet");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Car Wash Attendant");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Care Assistant");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Care Manager");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Careers Advisor");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Careers Officer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Caretaker");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Cargo Operator");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Carpenter");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Carpet Cleaner");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Carpet Fitter");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Carpet Retailer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Carphone Fitter");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Cartographer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Cartoonist");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Cashier");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Casual Worker");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Caterer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Catering Consultant");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Catering Manager");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Catering Staff");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Caulker");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Ceiling Contractor");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Ceiling Fixer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Cellarman");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Chambermaid");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Chandler");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Chaplain");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Charge Hand");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Charity Worker");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Chartered");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Chartered Accountant");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Chauffeur");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Chef");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Chemist");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Chicken Chaser");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Child Minder");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Childminder");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Chimney Sweep");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "China Restorer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Chiropodist");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Chiropractor");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Choreographer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Church Officer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Church Warden");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Cinema Manager");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Circus Proprietor");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Circus Worker");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Civil Engineer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Civil Servant");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Claims Adjustor");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Claims Assessor");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Claims Manager");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Clairvoyant");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Classroom Aide");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Cleaner");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Clergyman");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Cleric");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Clerk");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Commissioned");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Consultant");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Coroner");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Councillor");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Counsellor");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Dealer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Decorator");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Delivery Driver");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Doctor");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Driver");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Economist");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Editor");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Employee");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Employment");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Engineer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "English Teacher");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Entertainer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Envoy");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Executive");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Farmer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Fireman");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Floor Layer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Floor Manager");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Florist");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Flour Miller");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Flower Arranger");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Flying Instructor");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Foam Convertor");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Food Processor");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Footballer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Foreman");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Forensic Scientist");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Forest Ranger");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Forester");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Fork Lift Truck Driver");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Forwarding Agent");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Foster Parent");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Foundry Worker");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Fraud Investigator");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "French Polisher");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Fruiterer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Fuel Merchant");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Fund Raiser");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Funeral Director");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Funeral Furnisher");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Furnace Man");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Furniture Dealer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Furniture Remover");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Furniture Restorer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Furrier");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Gallery Owner");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Gambler");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Gamekeeper");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Gaming Board Inspector");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Gaming Club Manager");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Gaming Club Proprietor");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Garage Attendant");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Garage Foreman");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Garage Manager");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Garda");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Garden Designer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Gardener");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Gas Fitter");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Gas Mechanic");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Gas Technician");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Gate Keeper");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Genealogist");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "General Practitioner");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Geologist");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Geophysicist");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Gilder");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Glass Worker");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Glazier");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Goldsmith");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Golf Caddy");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Golf Club Professional");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Golfer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Goods Handler");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Governor");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Granite Technician");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Graphic Designer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Graphologist");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Grave Digger");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Gravel Merchant");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Green Keeper");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Greengrocer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Grocer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Groom");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Ground Worker");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Groundsman");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Guest House Owner");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Guest House Proprietor");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Gun Smith");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Gynaecologist");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Hairdresser");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Handyman");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Hardware Dealer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Haulage Contractor");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Hawker");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Health Advisor");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Health And Safety");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Health Care Assistant");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Health Consultant");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Health Nurse");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Health Planner");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Health Service");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Health Therapist");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Health Visitor");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Hearing Therapist");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Heating Engineer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Herbalist");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "HGV Driver");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "HGV Mechanic");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Highway Inspector");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Hire Car Driver");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Historian");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "History Teacher");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Hod Carrier");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Home Economist");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Home Help");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Homecare Manager");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Homeopath");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Homeworker");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Hop Merchant");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Horse Breeder");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Horse Dealer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Horse Riding Instructor");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Horse Trader");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Horse Trainer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Horticultural Consultant");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Horticulturalist");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Hosiery Mechanic");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Hosiery Worker");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Hospital Consultant");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Hospital Doctor");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Hospital Manager");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Hospital Orderly");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Hospital Technician");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Hospital Warden");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Hospital Worker");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Hostess");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Hot Foil Printer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Hotel Consultant");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Hotel Worker");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Hotelier");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Househusband");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Housekeeper");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Housewife");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Housing Assistant");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Housing Officer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Housing Supervisor");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Hygienist");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Hypnotherapist");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Hypnotist");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Ice Cream Vendor");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Illustrator");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Immigration Officer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Import Consultant");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Importer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Independent Means");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Induction Moulder");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Industrial Chemist");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Industrial Consultant");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Injection Moulder");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Inspector");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Instructor");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Instrument Engineer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Instrument Maker");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Instrument Supervisor");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Instrument Technician");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Insurance Agent");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Insurance Assessor");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Insurance Broker");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Insurance Consultant");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Insurance Inspector");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Insurance Staff");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Interior Decorator");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Interior Designer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Interpreter");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Interviewer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Inventor");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Investigator");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Investment Advisor");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Investment Banker");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Investment Manager");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Investment Strategist");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Ironmonger");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "IT Consultant");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "IT Manager");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "IT Trainer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Janitor");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Jazz Composer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Jeweller");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Jewellery");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Jockey");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Joiner");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Joinery Consultant");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Journalist");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Judge");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Keep Fit Instructor");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Kennel Hand");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Kitchen Worker");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Knitter");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Labelling Operator");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Laboratory Analyst");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Labourer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Laminator");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Lampshade Maker");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Land Agent");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Land Surveyor");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Landlady");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Landlord");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Landowner");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Landworker");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Lathe Operator");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Laundry Staff");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Laundry Worker");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Lavatory Attendant");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Law Clerk");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Lawn Mower");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Lawyer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Leaflet Distributor");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Leather Worker");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Lecturer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Ledger Clerk");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Legal Advisor");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Legal Assistant");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Legal Executive");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Legal Secretary");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Letting Agent");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Liaison Officer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Librarian");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Library Manager");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Licensed Premises");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Licensee");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Licensing");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Lifeguard");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Lift Attendant");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Lift Engineer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Lighterman");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Lighthouse Keeper");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Lighting Designer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Lighting Technician");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Lime Kiln Attendant");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Line Manager");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Line Worker");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Lineman");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Linguist");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Literary Agent");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Literary Editor");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Lithographer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Litigation Manager");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Loans Manager");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Local Government");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Lock Keeper");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Locksmith");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Locum Pharmacist");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Log Merchant");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Lorry Driver");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Loss Adjustor");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Loss Assessor");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Lumberjack");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Machine Fitters");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Machine Minder");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Machine Operator");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Machine Setter");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Machine Tool");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Machine Tool Fitter");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Machinist");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Magician");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Magistrate");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Magistrates Clerk");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Maid");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Maintenance Fitter");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Make Up Artist");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Manicurist");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Manufacturing");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Map Mounter");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Marble Finisher");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Marble Mason");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Marine Broker");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Marine Consultant");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Marine Electrician");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Marine Engineer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Marine Geologist");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Marine Pilot");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Marine Surveyor");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Market Gardener");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Market Research");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Market Researcher");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Market Trader");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Marketing Agent");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Marketing Assistant");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Marketing Coordinator");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Marketing Director");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Marketing Manager");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Marquee Erector");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Massage Therapist");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Masseur");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Masseuse");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Master Mariner");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Materials Controller");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Materials Manager");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Mathematician");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Maths Teacher");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Matron");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Mattress Maker");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Meat Inspector");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Meat Wholesaler");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Mechanic");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Medal Dealer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Medical Advisor");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Medical Assistant");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Medical Consultant");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Medical Officer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Medical Physicist");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Medical Practitioner");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Medical Researcher");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Medical Secretary");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Medical Student");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Medical Supplier");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Medical Technician");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Merchandiser");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Merchant");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Merchant Banker");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Merchant Seaman");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Messenger");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Metal Dealer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Metal Engineer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Metal Polisher");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Metal Worker");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Metallurgist");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Meteorologist");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Meter Reader");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Microbiologist");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Midwife");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Military Leader");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Milklady");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Milkman");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Mill Operator");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Mill Worker");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Miller");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Milliner");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Millwright");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Miner");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Mineralologist");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Minibus Driver");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Minicab Driver");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Mining Consultant");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Mining Engineer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Money Broker");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Moneylender");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Mooring Contractor");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Mortgage Broker");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Mortician");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Motor Dealer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Motor Engineer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Motor Fitter");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Motor Mechanic");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Motor Racing");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Motor Trader");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Museum Assistant");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Museum Attendant");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Music Teacher");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Musician");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Nanny");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Navigator");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Negotiator");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Neurologist");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Newsagent");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Night Porter");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Night Watchman");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Nuclear Scientist");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Nun");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Nurse");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Nursery Assistant");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Nursery Nurse");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Nursery Worker");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Nurseryman");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Nursing Assistant");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Nursing Auxiliary");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Nursing Manager");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Nursing Sister");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Nutritionist");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Off Shore");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Office Manager");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Office Worker");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Oil Broker");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Oil Rig Crew");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Opera Singer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Operations");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Operative");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Operator");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Optical");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Optical Advisor");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Optical Assistant");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Optician");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Optometrist");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Orchestral");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Organiser");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Organist");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Ornamental");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Ornithologist");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Orthopaedic");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Orthoptist");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Osteopath");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Outdoor Pursuits");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Outreach Worker");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Packaging");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Packer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Paediatrician");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Paint Consultant");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Painter");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Palaeobotanist");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Palaeontologist");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Pallet Maker");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Panel Beater");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Paramedic");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Park Attendant");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Park Keeper");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Park Ranger");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Partition Erector");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Parts Man");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Parts Manager");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Parts Supervisor");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Party Planner");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Pasteuriser");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Pastry Chef");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Patent Agent");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Patent Attorney");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Pathologist");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Patrolman");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Pattern Cutter");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Pattern Maker");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Pattern Weaver");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Pawnbroker");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Payroll Assistant");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Payroll Clerk");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Payroll Manager");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Payroll Supervisor");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Personnel Officer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Pest Controller");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Pet Minder");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Pharmacist");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Philatelist");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Photographer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Physician");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Physicist");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Physiologist");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Physiotherapist");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Piano Teacher");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Piano Tuner");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Picture Editor");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Picture Framer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Picture Reseacher");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Pig Man");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Pig Manager");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Pilot");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Pipe Fitter");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Pipe Inspector");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Pipe Insulator");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Pipe Layer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Planning Engineer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Planning Manager");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Planning Officer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Planning Technician");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Plant Attendant");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Plant Driver");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Plant Engineer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Plant Fitter");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Plant Manager");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Plant Operator");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Plasterer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Plastics Consultant");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Plastics Engineer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Plate Layer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Plater");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Playgroup Assistant");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Playgroup Leader");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Plumber");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Podiatrist");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Police Officer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Polisher");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Pool Attendant");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Pools Collector");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Porter");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Portfolio Manager");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Post Sorter");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Postman");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Postmaster");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Postwoman");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Potter");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Practice Manager");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Preacher");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Precision Engineer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Premises");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Premises Security");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Press Officer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Press Operator");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Press Setter");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Presser");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Priest");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Print Finisher");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Printer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Prison Chaplain");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Prison Officer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Private Investigator");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Probation Officer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Probation Worker");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Procurator Fiscal");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Produce Supervisor");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Producer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Product Installer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Product Manager");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Production Engineer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Production Hand");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Production Manager");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Production Planner");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Professional Boxer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Professional Racing");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Professional Wrestler");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Progress Chaser");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Progress Clerk");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Project Co-ordinator");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Project Engineer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Project Leader");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Project Manager");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Project Worker");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Projectionist");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Promoter");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Proof Reader");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Property Buyer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Property Dealer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Property Developer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Property Manager");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Property Valuer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Proprietor");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Psychiatrist");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Psychoanalyst");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Psychologist");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Psychotherapist");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Public House Manager");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Public Relations Of?cer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Publican");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Publicity Manager");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Publisher");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Publishing Manager");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Purchase Clerk");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Purchase Ledger Clerk");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Purchasing Assistant");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Purchasing Manager");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Purser");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Quality Controller");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Quality Engineer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Quality Inspector");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Quality Manager");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Quality Technician");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Quantity Surveyor");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Quarry Worker");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Racehorse Groom");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Racing Organiser");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Radio Controller");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Radio Director");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Radio Engineer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Radio Operator");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Radio Presenter");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Radio Producer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Radiographer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Radiologist");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Rally Driver");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Receptionist");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Recorder");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Records Supervisor");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Recovery Vehicle Coordinator");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Recreational");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Recruitment Consultant");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Rector");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Reflexologist");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Refractory Engineer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Refrigeration Engineer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Refuse Collector");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Registrar");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Regulator");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Relocation Agent");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Remedial Therapist");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Rent Collector");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Rent Offcer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Repair Man");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Repairer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Reporter");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Representative");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Reprographic Assistant");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Research Analyst");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Research Consultant");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Research Director");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Research Scientist");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Research Technician");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Researcher");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Resin Caster");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Restaurant Manager");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Restaurateur");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Restorer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Retired");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Revenue Clerk");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Revenue Officer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Riding Instructor");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Rig Worker");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Rigger");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Riveter");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Road Safety Officer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Road Sweeper");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Road Worker");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Roadworker");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Roof Tiler");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Roofer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Rose Grower");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Royal Marine");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Rug Maker");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Saddler");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Safety Officer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Sail Maker");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Sales Administrator");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Sales Assistant");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Sales Director");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Sales Engineer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Sales Executive");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Sales Manager");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Sales Representative");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Sales Support");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Salesman");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Saleswoman");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Sand Blaster");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Saw Miller");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Scaffolder");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "School Crossing");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "School Inspector");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Scientific Officer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Scientist");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Scrap Dealer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Screen Printer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Screen Writer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Script Writer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Sculptor");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Seaman");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Seamstress");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Secretary");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Security Consultant");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Security Controller");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Security Guard");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Security Officer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Servant");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Service Engineer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Service Manager");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Share Dealer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Sheet Metal Worker");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Shelf Filler");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Shelter Warden");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Shepherd");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Sheriff");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Sheriff Clerk");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Sheriff Principal");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Shift Controller");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Ship Broker");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Ship Builder");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Shipping Clerk");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Shipping Officer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Shipwright");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Shipyard Worker");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Shoe Maker");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Shoe Repairer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Shooting Instructor");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Shop Assistant");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Shop Fitter");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Shop Keeper");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Shop Manager");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Shop Proprietor");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Shot Blaster");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Show Jumper");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Showman");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Shunter");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Sign Maker");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Signalman");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Signwriter");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Site Agent");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Site Engineer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Skipper");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Slater");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Slaughterman");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Smallholder");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Social Worker");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Software Consultant");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Software Engineer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Soldier");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Solicitor");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Song Writer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Sound Artist");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Sound Engineer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Sound Technician");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Special Constable");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Special Needs");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Speech Therapist");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Sports Administrator");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Sports Coach");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Sports Commentator");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Sportsman");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Sportsperson");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Sportswoman");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Spring Maker");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Stable Hand");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Staff Nurse");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Stage Director");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Stage Hand");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Stage Manager");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Stage Mover");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Station Manager");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Stationer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Statistician");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Steel Erector");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Steel Worker");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Steeplejack");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Stenographer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Steward");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Stewardess");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Stock Controller");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Stock Manager");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Stockbroker");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Stockman");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Stocktaker");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Stone Cutter");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Stone Sawyer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Stonemason");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Store Detective");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Storeman");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Storewoman");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Street Entertainer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Street Trader");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Stud Hand");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Student");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Student Nurse");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Student Teacher");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Studio Manager");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Sub-Postmaster");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Sub-Postmistress");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Supervisor");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Supply Teacher");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Surgeon");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Surveyor");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Systems Analyst");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Systems Engineer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Systems Manager");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Tachograph Analyst");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Tacker");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Tailor");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Tank Farm Operative");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Tanker Driver");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Tanner");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Tattooist");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Tax Advisor");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Tax Analyst");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Tax Assistant");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Tax Consultant");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Tax Inspector");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Tax Manager");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Tax Officer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Taxi Controller");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Taxi Driver");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Taxidermist");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Tea Blender");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Tea Taster");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Teacher");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Teachers Assistant");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Technical Advisor");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Technical Analyst");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Technical Assistant");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Technical Author");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Technical Clerk");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Technical Co-ordinator");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Technical Director");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Technical Editor");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Technical Engineer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Technical Illustrator");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Technical Instructor");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Technical Liaison");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Technical Manager");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Technician");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Telecommunication");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Telecommunications");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Telegraphist");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Telemarketeer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Telephone Engineer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Telephonist");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Telesales Person");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Television Director");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Television Engineer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Television Presenter");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Television Producer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Telex Operator");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Temperature Time");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Tennis Coach");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Textile Consultant");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Textile Engineer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Textile Technician");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Textile Worker");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Thatcher");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Theatre Manager");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Theatre Technician");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Theatrical Agent");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Therapist");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Thermal Engineer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Thermal Insulator");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Ticket Agent");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Ticket Inspector");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Tiler");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Timber Inspector");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Timber Worker");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Tobacconist");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Toll Collector");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Tool Maker");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Tour Agent");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Tour Guide");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Town Clerk");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Town Planner");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Toy Maker");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Toy Trader");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Track Worker");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Tractor Driver");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Tractor Mechanic");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Trade Mark Agent");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Trade Union Official");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Trading Standards");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Traffic Warden");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Train Driver");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Trainee Manager");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Training Advisor");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Training Assistant");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Training Co-ordinator");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Training Consultant");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Training Instructor");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Training Manager");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Training Officer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Transcriber");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Translator");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Transport Clerk");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Transport Consultant");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Transport Controller");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Transport Engineer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Transport Manager");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Transport Officer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Transport Planner");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Travel Agent");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Travel Clerk");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Travel Consultant");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Travel Courier");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Travel Guide");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Travel Guide Writer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Travel Representative");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Travelling Showman");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Treasurer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Tree Feller");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Tree Surgeon");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Trichologist");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Trinity House Pilot");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Trout Farmer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Tug Skipper");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Tunneller");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Turf Accountant");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Turkey Farmer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Turner");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Tutor");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "TV Editor");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Typesetter");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Typewriter Engineer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Typist");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Tyre Builder");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Tyre Fitter");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Tyre Inspector");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Tyre Technician");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Undertaker");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Underwriter");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Upholsterer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Valuer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Valve Technician");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Van Driver");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Vehicle Assessor");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Vehicle Body Worker");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Vehicle Engineer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Vehicle Technician");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Ventriloquist");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Verger");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Veterinary Surgeon");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Vicar");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Video Artist");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Violin Maker");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Violinist");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Voluntary Worker");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Wages Clerk");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Waiter");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Waitress");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Warden");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Warehouse Manager");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Warehouseman");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Warehousewoman");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Watchmaker");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Weaver");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Weighbridge Clerk");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Weighbridge Operator");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Welder");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Welfare Assistant");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Welfare Officer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Welfare Rights Officer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Wheel Clamper");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Wholesale Newspaper");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Window Cleaner");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Window Dresser");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Windscreen Fitter");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Wine Merchant");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Wood Carver");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Wood Cutter");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Wood Worker");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Word Processing Operator");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Works Manager");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Writer");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Yacht Master");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Yard Manager");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Youth Hostel Warden");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Youth Worker");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Zoo Keeper");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Zoo Manager");

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "Name",
                keyValue: "Zoologist");

            migrationBuilder.DeleteData(
                table: "StarSigns",
                keyColumn: "Name",
                keyValue: "Aquarius");

            migrationBuilder.DeleteData(
                table: "StarSigns",
                keyColumn: "Name",
                keyValue: "Aries");

            migrationBuilder.DeleteData(
                table: "StarSigns",
                keyColumn: "Name",
                keyValue: "Cancer");

            migrationBuilder.DeleteData(
                table: "StarSigns",
                keyColumn: "Name",
                keyValue: "Capricornus");

            migrationBuilder.DeleteData(
                table: "StarSigns",
                keyColumn: "Name",
                keyValue: "Gemini");

            migrationBuilder.DeleteData(
                table: "StarSigns",
                keyColumn: "Name",
                keyValue: "Leo");

            migrationBuilder.DeleteData(
                table: "StarSigns",
                keyColumn: "Name",
                keyValue: "Libra");

            migrationBuilder.DeleteData(
                table: "StarSigns",
                keyColumn: "Name",
                keyValue: "Pisces");

            migrationBuilder.DeleteData(
                table: "StarSigns",
                keyColumn: "Name",
                keyValue: "Sagiattarius");

            migrationBuilder.DeleteData(
                table: "StarSigns",
                keyColumn: "Name",
                keyValue: "Scorpius");

            migrationBuilder.DeleteData(
                table: "StarSigns",
                keyColumn: "Name",
                keyValue: "Taurus");

            migrationBuilder.DeleteData(
                table: "StarSigns",
                keyColumn: "Name",
                keyValue: "Virgo");

            migrationBuilder.DropColumn(
                name: "ProfessionName",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "StarSignName",
                table: "Users");

            migrationBuilder.AddColumn<long>(
                name: "ProfessionId",
                table: "Users",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "StarSignId",
                table: "Users",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "StarSignId",
                table: "StarSigns",
                type: "bigint",
                nullable: false,
                defaultValue: 0L)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<long>(
                name: "ProfessionId",
                table: "Professions",
                type: "bigint",
                nullable: false,
                defaultValue: 0L)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_StarSigns",
                table: "StarSigns",
                column: "StarSignId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Professions",
                table: "Professions",
                column: "ProfessionId");

            migrationBuilder.InsertData(
                table: "Professions",
                columns: new[] { "ProfessionId", "Name" },
                values: new object[,]
                {
                    { 1L, "Accountant" },
                    { 776L, "Purchasing Assistant" },
                    { 775L, "Purchase Ledger Clerk" },
                    { 774L, "Purchase Clerk" },
                    { 773L, "Publishing Manager" },
                    { 772L, "Publisher" },
                    { 771L, "Publicity Manager" },
                    { 777L, "Purchasing Manager" },
                    { 770L, "Publican" },
                    { 768L, "Public House Manager" },
                    { 767L, "Psychotherapist" },
                    { 766L, "Psychologist" },
                    { 765L, "Psychoanalyst" },
                    { 764L, "Psychiatrist" },
                    { 763L, "Proprietor" },
                    { 769L, "Public Relations Of?cer" },
                    { 762L, "Property Valuer" },
                    { 778L, "Purser" },
                    { 780L, "Quality Engineer" },
                    { 794L, "Radiographer" },
                    { 793L, "Radio Producer" },
                    { 792L, "Radio Presenter" },
                    { 791L, "Radio Operator" },
                    { 790L, "Radio Engineer" },
                    { 789L, "Radio Director" },
                    { 779L, "Quality Controller" },
                    { 788L, "Radio Controller" },
                    { 786L, "Racehorse Groom" },
                    { 785L, "Quarry Worker" },
                    { 784L, "Quantity Surveyor" },
                    { 783L, "Quality Technician" },
                    { 782L, "Quality Manager" },
                    { 781L, "Quality Inspector" },
                    { 787L, "Racing Organiser" },
                    { 795L, "Radiologist" },
                    { 761L, "Property Manager" },
                    { 759L, "Property Dealer" },
                    { 740L, "Product Manager" },
                    { 739L, "Product Installer" },
                    { 738L, "Producer" },
                    { 737L, "Produce Supervisor" },
                    { 736L, "Procurator Fiscal" },
                    { 735L, "Probation Worker" },
                    { 741L, "Production Engineer" },
                    { 734L, "Probation Officer" },
                    { 732L, "Prison Officer" },
                    { 731L, "Prison Chaplain" },
                    { 730L, "Printer" },
                    { 729L, "Print Finisher" },
                    { 728L, "Priest" },
                    { 727L, "Presser" },
                    { 733L, "Private Investigator" },
                    { 760L, "Property Developer" },
                    { 742L, "Production Hand" },
                    { 744L, "Production Planner" },
                    { 758L, "Property Buyer" },
                    { 757L, "Proof Reader" },
                    { 756L, "Promoter" },
                    { 755L, "Projectionist" },
                    { 754L, "Project Worker" },
                    { 753L, "Project Manager" },
                    { 743L, "Production Manager" },
                    { 752L, "Project Leader" },
                    { 750L, "Project Co-ordinator" },
                    { 749L, "Progress Clerk" },
                    { 748L, "Progress Chaser" },
                    { 747L, "Professional Wrestler" },
                    { 746L, "Professional Racing" },
                    { 745L, "Professional Boxer" },
                    { 751L, "Project Engineer" },
                    { 726L, "Press Setter" },
                    { 796L, "Rally Driver" },
                    { 798L, "Recorder" },
                    { 848L, "Sales Administrator" },
                    { 847L, "Sail Maker" },
                    { 846L, "Safety Officer" },
                    { 845L, "Saddler" },
                    { 844L, "Rug Maker" },
                    { 843L, "Royal Marine" },
                    { 849L, "Sales Assistant" },
                    { 842L, "Rose Grower" },
                    { 840L, "Roof Tiler" },
                    { 839L, "Roadworker" },
                    { 838L, "Road Worker" },
                    { 837L, "Road Sweeper" },
                    { 836L, "Road Safety Officer" },
                    { 835L, "Riveter" },
                    { 841L, "Roofer" },
                    { 834L, "Rigger" },
                    { 850L, "Sales Director" },
                    { 852L, "Sales Executive" },
                    { 866L, "Screen Printer" },
                    { 865L, "Scrap Dealer" },
                    { 864L, "Scientist" },
                    { 863L, "Scientific Officer" },
                    { 862L, "School Inspector" },
                    { 861L, "School Crossing" },
                    { 851L, "Sales Engineer" },
                    { 860L, "Scaffolder" },
                    { 858L, "Sand Blaster" },
                    { 857L, "Saleswoman" },
                    { 856L, "Salesman" },
                    { 855L, "Sales Support" },
                    { 854L, "Sales Representative" },
                    { 853L, "Sales Manager" },
                    { 859L, "Saw Miller" },
                    { 797L, "Receptionist" },
                    { 833L, "Rig Worker" },
                    { 831L, "Revenue Officer" },
                    { 812L, "Rent Collector" },
                    { 811L, "Remedial Therapist" },
                    { 810L, "Relocation Agent" },
                    { 809L, "Regulator" },
                    { 808L, "Registrar" },
                    { 807L, "Refuse Collector" },
                    { 813L, "Rent Offcer" },
                    { 806L, "Refrigeration Engineer" },
                    { 804L, "Reflexologist" },
                    { 803L, "Rector" },
                    { 802L, "Recruitment Consultant" },
                    { 801L, "Recreational" },
                    { 800L, "Recovery Vehicle Coordinator" },
                    { 799L, "Records Supervisor" },
                    { 805L, "Refractory Engineer" },
                    { 832L, "Riding Instructor" },
                    { 814L, "Repair Man" },
                    { 816L, "Reporter" },
                    { 830L, "Revenue Clerk" },
                    { 829L, "Retired" },
                    { 828L, "Restorer" },
                    { 827L, "Restaurateur" },
                    { 826L, "Restaurant Manager" },
                    { 825L, "Resin Caster" },
                    { 815L, "Repairer" },
                    { 824L, "Researcher" },
                    { 822L, "Research Scientist" },
                    { 821L, "Research Director" },
                    { 820L, "Research Consultant" },
                    { 819L, "Research Analyst" },
                    { 818L, "Reprographic Assistant" },
                    { 817L, "Representative" },
                    { 823L, "Research Technician" },
                    { 725L, "Press Operator" },
                    { 724L, "Press Officer" },
                    { 723L, "Premises Security" },
                    { 631L, "Orthoptist" },
                    { 630L, "Orthopaedic" },
                    { 629L, "Ornithologist" },
                    { 628L, "Ornamental" },
                    { 627L, "Organist" },
                    { 626L, "Organiser" },
                    { 632L, "Osteopath" },
                    { 625L, "Orchestral" },
                    { 623L, "Optician" },
                    { 622L, "Optical Assistant" },
                    { 621L, "Optical Advisor" },
                    { 620L, "Optical" },
                    { 619L, "Operator" },
                    { 618L, "Operative" },
                    { 624L, "Optometrist" },
                    { 617L, "Operations" },
                    { 633L, "Outdoor Pursuits" },
                    { 635L, "Packaging" },
                    { 649L, "Parts Man" },
                    { 648L, "Partition Erector" },
                    { 647L, "Park Ranger" },
                    { 646L, "Park Keeper" },
                    { 645L, "Park Attendant" },
                    { 644L, "Paramedic" },
                    { 634L, "Outreach Worker" },
                    { 643L, "Panel Beater" },
                    { 641L, "Palaeontologist" },
                    { 640L, "Palaeobotanist" },
                    { 639L, "Painter" },
                    { 638L, "Paint Consultant" },
                    { 637L, "Paediatrician" },
                    { 636L, "Packer" },
                    { 642L, "Pallet Maker" },
                    { 650L, "Parts Manager" },
                    { 616L, "Opera Singer" },
                    { 614L, "Oil Broker" },
                    { 595L, "Neurologist" },
                    { 594L, "Negotiator" },
                    { 593L, "Navigator" },
                    { 592L, "Nanny" },
                    { 591L, "Musician" },
                    { 590L, "Music Teacher" },
                    { 596L, "Newsagent" },
                    { 589L, "Museum Attendant" },
                    { 587L, "Motor Trader" },
                    { 586L, "Motor Racing" },
                    { 585L, "Motor Mechanic" },
                    { 583L, "Motor Engineer" },
                    { 582L, "Motor Dealer" },
                    { 581L, "Mortician" },
                    { 588L, "Museum Assistant" },
                    { 615L, "Oil Rig Crew" },
                    { 597L, "Night Porter" },
                    { 599L, "Nuclear Scientist" },
                    { 613L, "Office Worker" },
                    { 612L, "Office Manager" },
                    { 611L, "Off Shore" },
                    { 610L, "Nutritionist" },
                    { 609L, "Nursing Sister" },
                    { 608L, "Nursing Manager" },
                    { 598L, "Night Watchman" },
                    { 607L, "Nursing Auxiliary" },
                    { 605L, "Nurseryman" },
                    { 604L, "Nursery Worker" },
                    { 603L, "Nursery Nurse" },
                    { 602L, "Nursery Assistant" },
                    { 601L, "Nurse" },
                    { 600L, "Nun" },
                    { 606L, "Nursing Assistant" },
                    { 651L, "Parts Supervisor" },
                    { 652L, "Party Planner" },
                    { 653L, "Pasteuriser" },
                    { 704L, "Playgroup Assistant" },
                    { 703L, "Plater" },
                    { 702L, "Plate Layer" },
                    { 701L, "Plastics Engineer" },
                    { 700L, "Plastics Consultant" },
                    { 699L, "Plasterer" },
                    { 705L, "Playgroup Leader" },
                    { 698L, "Plant Operator" },
                    { 696L, "Plant Fitter" },
                    { 695L, "Plant Engineer" },
                    { 694L, "Plant Driver" },
                    { 693L, "Plant Attendant" },
                    { 692L, "Planning Technician" },
                    { 691L, "Planning Officer" },
                    { 697L, "Plant Manager" },
                    { 690L, "Planning Manager" },
                    { 706L, "Plumber" },
                    { 708L, "Police Officer" },
                    { 722L, "Premises" },
                    { 721L, "Precision Engineer" },
                    { 720L, "Preacher" },
                    { 719L, "Practice Manager" },
                    { 718L, "Potter" },
                    { 717L, "Postwoman" },
                    { 707L, "Podiatrist" },
                    { 716L, "Postmaster" },
                    { 714L, "Post Sorter" },
                    { 713L, "Portfolio Manager" },
                    { 712L, "Porter" },
                    { 711L, "Pools Collector" },
                    { 710L, "Pool Attendant" },
                    { 709L, "Polisher" },
                    { 715L, "Postman" },
                    { 689L, "Planning Engineer" },
                    { 688L, "Pipe Layer" },
                    { 687L, "Pipe Insulator" },
                    { 667L, "Personnel Officer" },
                    { 666L, "Payroll Supervisor" },
                    { 665L, "Payroll Manager" },
                    { 664L, "Payroll Clerk" },
                    { 663L, "Payroll Assistant" },
                    { 662L, "Pawnbroker" },
                    { 668L, "Pest Controller" },
                    { 661L, "Pattern Weaver" },
                    { 659L, "Pattern Cutter" },
                    { 658L, "Patrolman" },
                    { 657L, "Pathologist" },
                    { 656L, "Patent Attorney" },
                    { 655L, "Patent Agent" },
                    { 654L, "Pastry Chef" },
                    { 660L, "Pattern Maker" },
                    { 669L, "Pet Minder" },
                    { 670L, "Pharmacist" },
                    { 671L, "Philatelist" },
                    { 686L, "Pipe Inspector" },
                    { 685L, "Pipe Fitter" },
                    { 684L, "Pilot" },
                    { 683L, "Pig Manager" },
                    { 682L, "Pig Man" },
                    { 681L, "Picture Reseacher" },
                    { 680L, "Picture Framer" },
                    { 679L, "Picture Editor" },
                    { 678L, "Piano Tuner" },
                    { 677L, "Piano Teacher" },
                    { 676L, "Physiotherapist" },
                    { 675L, "Physiologist" },
                    { 674L, "Physicist" },
                    { 673L, "Physician" },
                    { 672L, "Photographer" },
                    { 867L, "Screen Writer" },
                    { 580L, "Mortgage Broker" },
                    { 868L, "Script Writer" },
                    { 870L, "Seaman" },
                    { 1065L, "Training Instructor" },
                    { 1064L, "Training Consultant" },
                    { 1063L, "Training Co-ordinator" },
                    { 1062L, "Training Assistant" },
                    { 1061L, "Training Advisor" },
                    { 1060L, "Trainee Manager" },
                    { 1066L, "Training Manager" },
                    { 1059L, "Train Driver" },
                    { 1057L, "Trading Standards" },
                    { 1056L, "Trade Union Official" },
                    { 1055L, "Trade Mark Agent" },
                    { 1054L, "Tractor Mechanic" },
                    { 1053L, "Tractor Driver" },
                    { 1052L, "Track Worker" },
                    { 1058L, "Traffic Warden" },
                    { 1051L, "Toy Trader" },
                    { 1067L, "Training Officer" },
                    { 1069L, "Translator" },
                    { 1083L, "Travel Representative" },
                    { 1082L, "Travel Guide Writer" },
                    { 1081L, "Travel Guide" },
                    { 1080L, "Travel Courier" },
                    { 1079L, "Travel Consultant" },
                    { 1078L, "Travel Clerk" },
                    { 1068L, "Transcriber" },
                    { 1077L, "Travel Agent" },
                    { 1075L, "Transport Officer" },
                    { 1074L, "Transport Manager" },
                    { 1073L, "Transport Engineer" },
                    { 1072L, "Transport Controller" },
                    { 1071L, "Transport Consultant" },
                    { 1070L, "Transport Clerk" },
                    { 1076L, "Transport Planner" },
                    { 1084L, "Travelling Showman" },
                    { 1050L, "Toy Maker" },
                    { 1048L, "Town Clerk" },
                    { 1029L, "Textile Technician" },
                    { 1028L, "Textile Engineer" },
                    { 1027L, "Textile Consultant" },
                    { 1026L, "Tennis Coach" },
                    { 1025L, "Temperature Time" },
                    { 1024L, "Telex Operator" },
                    { 1030L, "Textile Worker" },
                    { 1023L, "Television Producer" },
                    { 1021L, "Television Engineer" },
                    { 1020L, "Television Director" },
                    { 1019L, "Telesales Person" },
                    { 1018L, "Telephonist" },
                    { 1017L, "Telephone Engineer" },
                    { 1016L, "Telemarketeer" },
                    { 1022L, "Television Presenter" },
                    { 1049L, "Town Planner" },
                    { 1031L, "Thatcher" },
                    { 1033L, "Theatre Technician" },
                    { 1047L, "Tour Guide" },
                    { 1046L, "Tour Agent" },
                    { 1045L, "Tool Maker" },
                    { 1044L, "Toll Collector" },
                    { 1043L, "Tobacconist" },
                    { 1042L, "Timber Worker" },
                    { 1032L, "Theatre Manager" },
                    { 1041L, "Timber Inspector" },
                    { 1039L, "Ticket Inspector" },
                    { 1038L, "Ticket Agent" },
                    { 1037L, "Thermal Insulator" },
                    { 1036L, "Thermal Engineer" },
                    { 1035L, "Therapist" },
                    { 1034L, "Theatrical Agent" },
                    { 1040L, "Tiler" },
                    { 1015L, "Telegraphist" },
                    { 1085L, "Treasurer" },
                    { 1087L, "Tree Surgeon" },
                    { 1137L, "Wheel Clamper" },
                    { 1136L, "Welfare Rights Officer" },
                    { 1135L, "Welfare Officer" },
                    { 1134L, "Welfare Assistant" },
                    { 1133L, "Welder" },
                    { 1132L, "Weighbridge Operator" },
                    { 1138L, "Wholesale Newspaper" },
                    { 1131L, "Weighbridge Clerk" },
                    { 1129L, "Watchmaker" },
                    { 1128L, "Warehousewoman" },
                    { 1127L, "Warehouseman" },
                    { 1126L, "Warehouse Manager" },
                    { 1125L, "Warden" },
                    { 1124L, "Waitress" },
                    { 1130L, "Weaver" },
                    { 1123L, "Waiter" },
                    { 1139L, "Window Cleaner" },
                    { 1141L, "Windscreen Fitter" },
                    { 1155L, "Zoologist" },
                    { 1154L, "Zoo Manager" },
                    { 1153L, "Zoo Keeper" },
                    { 1152L, "Youth Worker" },
                    { 1151L, "Youth Hostel Warden" },
                    { 1150L, "Yard Manager" },
                    { 1140L, "Window Dresser" },
                    { 1149L, "Yacht Master" },
                    { 1147L, "Works Manager" },
                    { 1146L, "Word Processing Operator" },
                    { 1145L, "Wood Worker" },
                    { 1144L, "Wood Cutter" },
                    { 1143L, "Wood Carver" },
                    { 1142L, "Wine Merchant" },
                    { 1148L, "Writer" },
                    { 1086L, "Tree Feller" },
                    { 1122L, "Wages Clerk" },
                    { 1120L, "Violinist" },
                    { 1101L, "Tyre Fitter" },
                    { 1100L, "Tyre Builder" },
                    { 1099L, "Typist" },
                    { 1098L, "Typewriter Engineer" },
                    { 1097L, "Typesetter" },
                    { 1096L, "Tutor" },
                    { 1102L, "Tyre Inspector" },
                    { 1095L, "Turner" },
                    { 1093L, "Turf Accountant" },
                    { 1092L, "Tunneller" },
                    { 1091L, "Tug Skipper" },
                    { 1090L, "Trout Farmer" },
                    { 1089L, "Trinity House Pilot" },
                    { 1088L, "Trichologist" },
                    { 1094L, "Turkey Farmer" },
                    { 1121L, "Voluntary Worker" },
                    { 1103L, "Tyre Technician" },
                    { 1105L, "Underwriter" },
                    { 1119L, "Violin Maker" },
                    { 1118L, "Video Artist" },
                    { 1117L, "Vicar" },
                    { 1116L, "Veterinary Surgeon" },
                    { 1115L, "Verger" },
                    { 1114L, "Ventriloquist" },
                    { 1104L, "Undertaker" },
                    { 1113L, "Vehicle Technician" },
                    { 1111L, "Vehicle Body Worker" },
                    { 1110L, "Vehicle Assessor" },
                    { 1109L, "Van Driver" },
                    { 1108L, "Valve Technician" },
                    { 1107L, "Valuer" },
                    { 1106L, "Upholsterer" },
                    { 1112L, "Vehicle Engineer" },
                    { 1014L, "Telecommunications" },
                    { 1013L, "Telecommunication" },
                    { 1012L, "Technician" },
                    { 920L, "Solicitor" },
                    { 919L, "Soldier" },
                    { 918L, "Software Engineer" },
                    { 917L, "Software Consultant" },
                    { 916L, "Social Worker" },
                    { 915L, "Smallholder" },
                    { 921L, "Song Writer" },
                    { 914L, "Slaughterman" },
                    { 912L, "Skipper" },
                    { 911L, "Site Engineer" },
                    { 910L, "Site Agent" },
                    { 909L, "Signwriter" },
                    { 908L, "Signalman" },
                    { 907L, "Sign Maker" },
                    { 913L, "Slater" },
                    { 906L, "Shunter" },
                    { 922L, "Sound Artist" },
                    { 924L, "Sound Technician" },
                    { 938L, "Stage Hand" },
                    { 937L, "Stage Director" },
                    { 936L, "Staff Nurse" },
                    { 935L, "Stable Hand" },
                    { 934L, "Spring Maker" },
                    { 933L, "Sportswoman" },
                    { 923L, "Sound Engineer" },
                    { 932L, "Sportsperson" },
                    { 930L, "Sports Commentator" },
                    { 929L, "Sports Coach" },
                    { 928L, "Sports Administrator" },
                    { 927L, "Speech Therapist" },
                    { 926L, "Special Needs" },
                    { 925L, "Special Constable" },
                    { 931L, "Sportsman" },
                    { 939L, "Stage Manager" },
                    { 905L, "Showman" },
                    { 903L, "Shot Blaster" },
                    { 884L, "Shepherd" },
                    { 883L, "Shelter Warden" },
                    { 882L, "Shelf Filler" },
                    { 881L, "Sheet Metal Worker" },
                    { 880L, "Share Dealer" },
                    { 879L, "Service Manager" },
                    { 885L, "Sheriff" },
                    { 878L, "Service Engineer" },
                    { 876L, "Security Officer" },
                    { 875L, "Security Guard" },
                    { 874L, "Security Controller" },
                    { 873L, "Security Consultant" },
                    { 872L, "Secretary" },
                    { 871L, "Seamstress" },
                    { 877L, "Servant" },
                    { 904L, "Show Jumper" },
                    { 886L, "Sheriff Clerk" },
                    { 888L, "Shift Controller" },
                    { 902L, "Shop Proprietor" },
                    { 901L, "Shop Manager" },
                    { 900L, "Shop Keeper" },
                    { 899L, "Shop Fitter" },
                    { 898L, "Shop Assistant" },
                    { 897L, "Shooting Instructor" },
                    { 887L, "Sheriff Principal" },
                    { 896L, "Shoe Repairer" },
                    { 894L, "Shipyard Worker" },
                    { 893L, "Shipwright" },
                    { 892L, "Shipping Officer" },
                    { 891L, "Shipping Clerk" },
                    { 890L, "Ship Builder" },
                    { 889L, "Ship Broker" },
                    { 895L, "Shoe Maker" },
                    { 940L, "Stage Mover" },
                    { 941L, "Station Manager" },
                    { 942L, "Stationer" },
                    { 993L, "Taxi Driver" },
                    { 992L, "Taxi Controller" },
                    { 991L, "Tax Officer" },
                    { 990L, "Tax Manager" },
                    { 989L, "Tax Inspector" },
                    { 988L, "Tax Consultant" },
                    { 994L, "Taxidermist" },
                    { 987L, "Tax Assistant" },
                    { 985L, "Tax Advisor" },
                    { 984L, "Tattooist" },
                    { 983L, "Tanner" },
                    { 982L, "Tanker Driver" },
                    { 981L, "Tank Farm Operative" },
                    { 980L, "Tailor" },
                    { 986L, "Tax Analyst" },
                    { 979L, "Tacker" },
                    { 995L, "Tea Blender" },
                    { 997L, "Teacher" },
                    { 1011L, "Technical Manager" },
                    { 1010L, "Technical Liaison" },
                    { 1009L, "Technical Instructor" },
                    { 1008L, "Technical Illustrator" },
                    { 1007L, "Technical Engineer" },
                    { 1006L, "Technical Editor" },
                    { 996L, "Tea Taster" },
                    { 1005L, "Technical Director" },
                    { 1003L, "Technical Clerk" },
                    { 1002L, "Technical Author" },
                    { 1001L, "Technical Assistant" },
                    { 1000L, "Technical Analyst" },
                    { 999L, "Technical Advisor" },
                    { 998L, "Teachers Assistant" },
                    { 1004L, "Technical Co-ordinator" },
                    { 978L, "Tachograph Analyst" },
                    { 977L, "TV Editor" },
                    { 976L, "Systems Manager" },
                    { 956L, "Stone Sawyer" },
                    { 955L, "Stone Cutter" },
                    { 954L, "Stocktaker" },
                    { 953L, "Stockman" },
                    { 952L, "Stockbroker" },
                    { 951L, "Stock Manager" },
                    { 957L, "Stonemason" },
                    { 950L, "Stock Controller" },
                    { 948L, "Steward" },
                    { 947L, "Stenographer" },
                    { 946L, "Steeplejack" },
                    { 945L, "Steel Worker" },
                    { 944L, "Steel Erector" },
                    { 943L, "Statistician" },
                    { 949L, "Stewardess" },
                    { 958L, "Store Detective" },
                    { 959L, "Storeman" },
                    { 960L, "Storewoman" },
                    { 975L, "Systems Engineer" },
                    { 974L, "Systems Analyst" },
                    { 973L, "Surveyor" },
                    { 972L, "Surgeon" },
                    { 971L, "Supply Teacher" },
                    { 970L, "Supervisor" },
                    { 969L, "Sub-Postmistress" },
                    { 968L, "Sub-Postmaster" },
                    { 967L, "Studio Manager" },
                    { 966L, "Student Teacher" },
                    { 965L, "Student Nurse" },
                    { 964L, "Student" },
                    { 963L, "Stud Hand" },
                    { 962L, "Street Trader" },
                    { 961L, "Street Entertainer" },
                    { 869L, "Sculptor" },
                    { 579L, "Mooring Contractor" },
                    { 584L, "Motor Fitter" },
                    { 577L, "Money Broker" },
                    { 196L, "Charge Hand" },
                    { 195L, "Chaplain" },
                    { 194L, "Chandler" },
                    { 193L, "Chambermaid" },
                    { 192L, "Cellarman" },
                    { 191L, "Ceiling Fixer" },
                    { 197L, "Charity Worker" },
                    { 190L, "Ceiling Contractor" },
                    { 188L, "Catering Staff" },
                    { 187L, "Catering Manager" },
                    { 186L, "Catering Consultant" },
                    { 185L, "Caterer" },
                    { 184L, "Casual Worker" },
                    { 183L, "Cashier" },
                    { 189L, "Caulker" },
                    { 182L, "Cartoonist" },
                    { 198L, "Chartered" },
                    { 200L, "Chauffeur" },
                    { 214L, "Circus Proprietor" },
                    { 213L, "Cinema Manager" },
                    { 212L, "Church Warden" },
                    { 211L, "Church Officer" },
                    { 210L, "Choreographer" },
                    { 209L, "Chiropractor" },
                    { 199L, "Chartered Accountant" },
                    { 208L, "Chiropodist" },
                    { 206L, "Chimney Sweep" },
                    { 205L, "Childminder" },
                    { 204L, "Child Minder" },
                    { 203L, "Chicken Chaser" },
                    { 202L, "Chemist" },
                    { 201L, "Chef" },
                    { 207L, "China Restorer" },
                    { 215L, "Circus Worker" },
                    { 181L, "Cartographer" },
                    { 179L, "Carpet Retailer" },
                    { 160L, "Cafe Worker" },
                    { 159L, "Cafe Staff" },
                    { 158L, "Cafe Owner" },
                    { 157L, "Cable TV Installer" },
                    { 156L, "Cable Jointer" },
                    { 155L, "Cable Contractor" },
                    { 161L, "Calibration Manager" },
                    { 154L, "Cabinet Maker" },
                    { 152L, "Buyer" },
                    { 151L, "Butler" },
                    { 150L, "Butchery Manager" },
                    { 149L, "Butcher" },
                    { 148L, "Business Proprietor" },
                    { 147L, "Business Consultant" },
                    { 153L, "Cab Driver" },
                    { 180L, "Carphone Fitter" },
                    { 162L, "Camera Repairer" },
                    { 164L, "Car Dealer" },
                    { 178L, "Carpet Fitter" },
                    { 177L, "Carpet Cleaner" },
                    { 176L, "Carpenter" },
                    { 175L, "Cargo Operator" },
                    { 174L, "Caretaker" },
                    { 173L, "Careers Officer" },
                    { 163L, "Cameraman" },
                    { 172L, "Careers Advisor" },
                    { 170L, "Care Assistant" },
                    { 169L, "Car Wash Attendant" },
                    { 168L, "Car Valet" },
                    { 167L, "Car Salesman" },
                    { 166L, "Car Park Attendant" },
                    { 165L, "Car Delivery Driver" },
                    { 171L, "Care Manager" },
                    { 216L, "Civil Engineer" },
                    { 217L, "Civil Servant" },
                    { 218L, "Claims Adjustor" },
                    { 269L, "Fund Raiser" },
                    { 268L, "Fuel Merchant" },
                    { 267L, "Fruiterer" },
                    { 266L, "French Polisher" },
                    { 265L, "Fraud Investigator" },
                    { 264L, "Foundry Worker" },
                    { 270L, "Funeral Director" },
                    { 263L, "Foster Parent" },
                    { 261L, "Fork Lift Truck Driver" },
                    { 260L, "Forester" },
                    { 259L, "Forest Ranger" },
                    { 258L, "Forensic Scientist" },
                    { 257L, "Foreman" },
                    { 256L, "Footballer" },
                    { 262L, "Forwarding Agent" },
                    { 255L, "Food Processor" },
                    { 271L, "Funeral Furnisher" },
                    { 273L, "Furniture Dealer" },
                    { 287L, "Garden Designer" },
                    { 286L, "Garda" },
                    { 285L, "Garage Manager" },
                    { 578L, "Moneylender" },
                    { 283L, "Garage Attendant" },
                    { 282L, "Gaming Club Proprietor" },
                    { 272L, "Furnace Man" },
                    { 281L, "Gaming Club Manager" },
                    { 279L, "Gamekeeper" },
                    { 278L, "Gambler" },
                    { 277L, "Gallery Owner" },
                    { 276L, "Furrier" },
                    { 275L, "Furniture Restorer" },
                    { 274L, "Furniture Remover" },
                    { 280L, "Gaming Board Inspector" },
                    { 254L, "Foam Convertor" },
                    { 253L, "Flying Instructor" },
                    { 252L, "Flower Arranger" },
                    { 232L, "Dealer" },
                    { 231L, "Counsellor" },
                    { 230L, "Councillor" },
                    { 229L, "Coroner" },
                    { 228L, "Consultant" },
                    { 227L, "Commissioned" },
                    { 233L, "Decorator" },
                    { 226L, "Clerk" },
                    { 224L, "Clergyman" },
                    { 223L, "Cleaner" },
                    { 222L, "Classroom Aide" },
                    { 221L, "Clairvoyant" },
                    { 220L, "Claims Manager" },
                    { 219L, "Claims Assessor" },
                    { 225L, "Cleric" },
                    { 234L, "Delivery Driver" },
                    { 235L, "Doctor" },
                    { 236L, "Driver" },
                    { 251L, "Flour Miller" },
                    { 250L, "Florist" },
                    { 249L, "Floor Manager" },
                    { 248L, "Floor Layer" },
                    { 247L, "Fireman" },
                    { 246L, "Farmer" },
                    { 245L, "Executive" },
                    { 244L, "Envoy" },
                    { 243L, "Entertainer" },
                    { 242L, "English Teacher" },
                    { 241L, "Engineer" },
                    { 240L, "Employment" },
                    { 239L, "Employee" },
                    { 238L, "Editor" },
                    { 237L, "Economist" },
                    { 146L, "Bus Valeter" },
                    { 288L, "Gardener" },
                    { 145L, "Bus Mechanic" },
                    { 143L, "Bus Conductor" },
                    { 51L, "Archaeologist" },
                    { 50L, "Arborist" },
                    { 49L, "Arbitrator" },
                    { 48L, "Applications Programmer" },
                    { 47L, "Applications Engineer" },
                    { 46L, "Antique Dealer" },
                    { 52L, "Architect" },
                    { 45L, "Anthropologist" },
                    { 43L, "Analytical Chemist" },
                    { 42L, "Analyst" },
                    { 41L, "Anaesthetist" },
                    { 40L, "Amusement Arcade Worker" },
                    { 39L, "Ambulance Driver" },
                    { 38L, "Ambulance Crew" },
                    { 44L, "Animal Breeder" },
                    { 37L, "Ambulance Controller" },
                    { 53L, "Archivist" },
                    { 55L, "Armourer" },
                    { 69L, "Assistant Manager" },
                    { 68L, "Assistant Cook" },
                    { 67L, "Assistant Caretaker" },
                    { 66L, "Assistant" },
                    { 65L, "Assessor" },
                    { 64L, "Assembly Worker" },
                    { 54L, "Area Manager" },
                    { 63L, "Arts" },
                    { 61L, "Artexer" },
                    { 60L, "Art Restorer" },
                    { 59L, "Art Historian" },
                    { 58L, "Art Dealer" },
                    { 57L, "Art Critic" },
                    { 56L, "Aromatherapist" },
                    { 62L, "Artist" },
                    { 70L, "Assistant Nurse" },
                    { 36L, "Almoner" },
                    { 34L, "Airport Controller" },
                    { 15L, "Administration Staff" },
                    { 14L, "Administration Manager" },
                    { 13L, "Administration Clerk" },
                    { 12L, "Administration Assistant" },
                    { 11L, "Adjustor" },
                    { 10L, "Acupuncturist" },
                    { 16L, "Administrator" },
                    { 9L, "Actuary" },
                    { 7L, "Actor" },
                    { 6L, "Acoustic Engineer" },
                    { 5L, "Accounts Staff" },
                    { 4L, "Accounts Manager" },
                    { 3L, "Accounts Clerk" },
                    { 2L, "Accounts Assistant" },
                    { 8L, "Actress" },
                    { 35L, "Airport Manager" },
                    { 17L, "Advertising Agent" },
                    { 19L, "Advertising Clerk" },
                    { 33L, "Airman" },
                    { 32L, "Aircraft Surface Finisher" },
                    { 31L, "Aircraft Maintenance Engineer" },
                    { 30L, "Aircraft Engineer" },
                    { 29L, "Aircraft Designer" },
                    { 28L, "Air Traffic Controller" },
                    { 18L, "Advertising Assistant" },
                    { 27L, "Agent" },
                    { 25L, "Aerobic Instructor" },
                    { 24L, "Aerial Erector" },
                    { 23L, "Advertising Staff" },
                    { 22L, "Advertising Manager" },
                    { 21L, "Advertising Executive" },
                    { 20L, "Advertising Contractor" },
                    { 26L, "Aeronautical Engineer" },
                    { 71L, "Assistant Teacher" },
                    { 72L, "Astrologer" },
                    { 73L, "Astronomer" },
                    { 124L, "Branch Manager" },
                    { 123L, "Botanist" },
                    { 122L, "Bookmaker" },
                    { 121L, "Booking Clerk" },
                    { 120L, "Booking Agent" },
                    { 119L, "Book-Keeper" },
                    { 125L, "Breeder" },
                    { 118L, "Book Seller" },
                    { 116L, "Bodyshop" },
                    { 115L, "Bodyguard" },
                    { 114L, "Body Fitter" },
                    { 113L, "Boat Builder" },
                    { 112L, "Blinds Installer" },
                    { 111L, "Blind Fitter" },
                    { 117L, "Book Binder" },
                    { 110L, "Blind Assembler" },
                    { 126L, "Brewer" },
                    { 128L, "Brewery Worker" },
                    { 142L, "Bus Company" },
                    { 141L, "Bursar" },
                    { 140L, "Building Surveyor" },
                    { 139L, "Building Manager" },
                    { 138L, "Building Inspector" },
                    { 137L, "Building Foreman" },
                    { 127L, "Brewery Manager" },
                    { 136L, "Building Estimator" },
                    { 134L, "Building Control" },
                    { 133L, "Building Advisor" },
                    { 132L, "Builders Labourer" },
                    { 131L, "Builder" },
                    { 130L, "Broadcaster" },
                    { 129L, "Bricklayer" },
                    { 135L, "Building Engineer" },
                    { 109L, "Blacksmith" },
                    { 108L, "Biologist" },
                    { 107L, "Biochemist" },
                    { 87L, "Baker" },
                    { 86L, "Bailiff" },
                    { 85L, "Baggage Handler" },
                    { 84L, "Bacon Curer" },
                    { 83L, "Auxiliary Nurse" },
                    { 82L, "Auto Electrician" },
                    { 88L, "Bakery Assistant" },
                    { 81L, "Auditor" },
                    { 79L, "Audit Clerk" },
                    { 78L, "Audiologist" },
                    { 77L, "Auctioneer" },
                    { 76L, "Auction Worker" },
                    { 75L, "Au Pair" },
                    { 74L, "Attendant" },
                    { 80L, "Audit Manager" },
                    { 89L, "Bakery Manager" },
                    { 90L, "Bakery Operator" },
                    { 91L, "Balloonist" },
                    { 106L, "Bingo Caller" },
                    { 105L, "Bill Poster" },
                    { 104L, "Betting Shop" },
                    { 103L, "Beauty Therapist" },
                    { 102L, "Beautician" },
                    { 101L, "Barrister" },
                    { 100L, "Barman" },
                    { 99L, "Barmaid" },
                    { 98L, "Barber" },
                    { 97L, "Bar Steward" },
                    { 96L, "Bar Manager" },
                    { 95L, "Baptist Minister" },
                    { 94L, "Bank Messenger" },
                    { 93L, "Bank Manager" },
                    { 92L, "Bank Clerk" },
                    { 144L, "Bus Driver" },
                    { 289L, "Gas Fitter" },
                    { 284L, "Garage Foreman" },
                    { 291L, "Gas Technician" },
                    { 486L, "Loss Adjustor" },
                    { 485L, "Lorry Driver" },
                    { 484L, "Log Merchant" },
                    { 483L, "Locum Pharmacist" },
                    { 482L, "Locksmith" },
                    { 481L, "Lock Keeper" },
                    { 487L, "Loss Assessor" },
                    { 480L, "Local Government" },
                    { 478L, "Litigation Manager" },
                    { 477L, "Lithographer" },
                    { 476L, "Literary Editor" },
                    { 475L, "Literary Agent" },
                    { 474L, "Linguist" },
                    { 473L, "Lineman" },
                    { 479L, "Loans Manager" },
                    { 472L, "Line Worker" },
                    { 488L, "Lumberjack" },
                    { 490L, "Machine Minder" },
                    { 504L, "Map Mounter" },
                    { 503L, "Manufacturing" },
                    { 502L, "Manicurist" },
                    { 501L, "Make Up Artist" },
                    { 500L, "Maintenance Fitter" },
                    { 499L, "Maid" },
                    { 489L, "Machine Fitters" },
                    { 498L, "Magistrates Clerk" },
                    { 496L, "Magician" },
                    { 495L, "Machinist" },
                    { 494L, "Machine Tool Fitter" },
                    { 493L, "Machine Tool" },
                    { 492L, "Machine Setter" },
                    { 491L, "Machine Operator" },
                    { 497L, "Magistrate" },
                    { 505L, "Marble Finisher" },
                    { 471L, "Line Manager" },
                    { 469L, "Lighting Technician" },
                    { 450L, "Lecturer" },
                    { 449L, "Leather Worker" },
                    { 448L, "Leaflet Distributor" },
                    { 447L, "Lawyer" },
                    { 446L, "Lawn Mower" },
                    { 445L, "Law Clerk" },
                    { 451L, "Ledger Clerk" },
                    { 444L, "Lavatory Attendant" },
                    { 442L, "Laundry Staff" },
                    { 441L, "Lathe Operator" },
                    { 290L, "Gas Mechanic" },
                    { 439L, "Landowner" },
                    { 438L, "Landlord" },
                    { 437L, "Landlady" },
                    { 443L, "Laundry Worker" },
                    { 470L, "Lime Kiln Attendant" },
                    { 452L, "Legal Advisor" },
                    { 454L, "Legal Executive" },
                    { 468L, "Lighting Designer" },
                    { 467L, "Lighthouse Keeper" },
                    { 466L, "Lighterman" },
                    { 465L, "Lift Engineer" },
                    { 464L, "Lift Attendant" },
                    { 463L, "Lifeguard" },
                    { 453L, "Legal Assistant" },
                    { 462L, "Licensing" },
                    { 460L, "Licensed Premises" },
                    { 459L, "Library Manager" },
                    { 458L, "Librarian" },
                    { 457L, "Liaison Officer" },
                    { 456L, "Letting Agent" },
                    { 455L, "Legal Secretary" },
                    { 461L, "Licensee" },
                    { 436L, "Land Surveyor" },
                    { 506L, "Marble Mason" },
                    { 508L, "Marine Consultant" },
                    { 558L, "Metallurgist" },
                    { 557L, "Metal Worker" },
                    { 556L, "Metal Polisher" },
                    { 555L, "Metal Engineer" },
                    { 554L, "Metal Dealer" },
                    { 553L, "Messenger" },
                    { 559L, "Meteorologist" },
                    { 552L, "Merchant Seaman" },
                    { 550L, "Merchant" },
                    { 549L, "Merchandiser" },
                    { 548L, "Medical Technician" },
                    { 547L, "Medical Supplier" },
                    { 546L, "Medical Student" },
                    { 545L, "Medical Secretary" },
                    { 551L, "Merchant Banker" },
                    { 544L, "Medical Researcher" },
                    { 560L, "Meter Reader" },
                    { 562L, "Midwife" },
                    { 576L, "Mining Engineer" },
                    { 575L, "Mining Consultant" },
                    { 574L, "Minicab Driver" },
                    { 573L, "Minibus Driver" },
                    { 572L, "Mineralologist" },
                    { 571L, "Miner" },
                    { 561L, "Microbiologist" },
                    { 570L, "Millwright" },
                    { 568L, "Miller" },
                    { 567L, "Mill Worker" },
                    { 566L, "Mill Operator" },
                    { 565L, "Milkman" },
                    { 564L, "Milklady" },
                    { 563L, "Military Leader" },
                    { 569L, "Milliner" },
                    { 507L, "Marine Broker" },
                    { 543L, "Medical Practitioner" },
                    { 541L, "Medical Officer" },
                    { 522L, "Marketing Manager" },
                    { 521L, "Marketing Director" },
                    { 520L, "Marketing Coordinator" },
                    { 519L, "Marketing Assistant" },
                    { 518L, "Marketing Agent" },
                    { 517L, "Market Trader" },
                    { 523L, "Marquee Erector" },
                    { 516L, "Market Researcher" },
                    { 514L, "Market Gardener" },
                    { 513L, "Marine Surveyor" },
                    { 512L, "Marine Pilot" },
                    { 511L, "Marine Geologist" },
                    { 510L, "Marine Engineer" },
                    { 509L, "Marine Electrician" },
                    { 515L, "Market Research" },
                    { 542L, "Medical Physicist" },
                    { 524L, "Massage Therapist" },
                    { 526L, "Masseuse" },
                    { 540L, "Medical Consultant" },
                    { 539L, "Medical Assistant" },
                    { 538L, "Medical Advisor" },
                    { 537L, "Medal Dealer" },
                    { 536L, "Mechanic" }
                });

            migrationBuilder.InsertData(
                table: "Professions",
                columns: new[] { "ProfessionId", "Name" },
                values: new object[,]
                {
                    { 535L, "Meat Wholesaler" },
                    { 525L, "Masseur" },
                    { 534L, "Meat Inspector" },
                    { 532L, "Matron" },
                    { 531L, "Maths Teacher" },
                    { 530L, "Mathematician" },
                    { 529L, "Materials Manager" },
                    { 528L, "Materials Controller" },
                    { 527L, "Master Mariner" },
                    { 533L, "Mattress Maker" },
                    { 435L, "Land Agent" },
                    { 440L, "Landworker" },
                    { 433L, "Laminator" },
                    { 341L, "Hire Car Driver" },
                    { 340L, "Highway Inspector" },
                    { 339L, "Herbalist" },
                    { 338L, "Heating Engineer" },
                    { 337L, "Hearing Therapist" },
                    { 336L, "Health Visitor" },
                    { 342L, "Historian" },
                    { 335L, "Health Therapist" },
                    { 333L, "Health Planner" },
                    { 332L, "Health Nurse" },
                    { 331L, "Health Consultant" },
                    { 330L, "Health Care Assistant" },
                    { 329L, "Health And Safety" },
                    { 328L, "Health Advisor" },
                    { 334L, "Health Service" },
                    { 327L, "Hawker" },
                    { 343L, "History Teacher" },
                    { 345L, "Home Economist" },
                    { 359L, "Hosiery Worker" },
                    { 358L, "Hosiery Mechanic" },
                    { 357L, "Horticulturalist" },
                    { 434L, "Lampshade Maker" },
                    { 355L, "Horse Trainer" },
                    { 354L, "Horse Trader" },
                    { 344L, "Hod Carrier" },
                    { 353L, "Horse Riding Instructor" },
                    { 351L, "Horse Breeder" },
                    { 350L, "Hop Merchant" },
                    { 349L, "Homeworker" },
                    { 348L, "Homeopath" },
                    { 347L, "Homecare Manager" },
                    { 346L, "Home Help" },
                    { 352L, "Horse Dealer" },
                    { 360L, "Hospital Consultant" },
                    { 326L, "Haulage Contractor" },
                    { 324L, "Handyman" },
                    { 305L, "Governor" },
                    { 304L, "Goods Handler" },
                    { 303L, "Golfer" },
                    { 302L, "Golf Club Professional" },
                    { 301L, "Golf Caddy" },
                    { 300L, "Goldsmith" },
                    { 306L, "Granite Technician" },
                    { 299L, "Glazier" },
                    { 297L, "Gilder" },
                    { 296L, "Geophysicist" },
                    { 295L, "Geologist" },
                    { 294L, "General Practitioner" },
                    { 293L, "Genealogist" },
                    { 292L, "Gate Keeper" },
                    { 298L, "Glass Worker" },
                    { 325L, "Hardware Dealer" },
                    { 307L, "Graphic Designer" },
                    { 309L, "Grave Digger" },
                    { 323L, "Hairdresser" },
                    { 322L, "HGV Mechanic" },
                    { 321L, "HGV Driver" },
                    { 320L, "Gynaecologist" },
                    { 319L, "Gun Smith" },
                    { 318L, "Guest House Proprietor" },
                    { 308L, "Graphologist" },
                    { 317L, "Guest House Owner" },
                    { 315L, "Ground Worker" },
                    { 314L, "Groom" },
                    { 313L, "Grocer" },
                    { 312L, "Greengrocer" },
                    { 311L, "Green Keeper" },
                    { 310L, "Gravel Merchant" },
                    { 316L, "Groundsman" },
                    { 361L, "Hospital Doctor" },
                    { 356L, "Horticultural Consultant" },
                    { 363L, "Hospital Orderly" },
                    { 414L, "Investment Manager" },
                    { 413L, "Investment Banker" },
                    { 412L, "Investment Advisor" },
                    { 411L, "Investigator" },
                    { 410L, "Inventor" },
                    { 409L, "Interviewer" },
                    { 415L, "Investment Strategist" },
                    { 408L, "Interpreter" },
                    { 406L, "Interior Decorator" },
                    { 405L, "Insurance Staff" },
                    { 362L, "Hospital Manager" },
                    { 403L, "Insurance Consultant" },
                    { 402L, "Insurance Broker" },
                    { 401L, "Insurance Assessor" },
                    { 407L, "Interior Designer" },
                    { 400L, "Insurance Agent" },
                    { 416L, "Ironmonger" },
                    { 418L, "Jazz Composer" },
                    { 432L, "Labourer" },
                    { 431L, "Laboratory Analyst" },
                    { 430L, "Labelling Operator" },
                    { 429L, "Knitter" },
                    { 428L, "Kitchen Worker" },
                    { 427L, "Kennel Hand" },
                    { 417L, "Janitor" },
                    { 426L, "Keep Fit Instructor" },
                    { 424L, "Journalist" },
                    { 423L, "Joinery Consultant" },
                    { 422L, "Joiner" },
                    { 421L, "Jockey" },
                    { 420L, "Jewellery" },
                    { 419L, "Jeweller" },
                    { 425L, "Judge" },
                    { 399L, "Instrument Technician" },
                    { 404L, "Insurance Inspector" },
                    { 397L, "Instrument Maker" },
                    { 377L, "Housing Supervisor" },
                    { 376L, "Housing Officer" },
                    { 375L, "Housing Assistant" },
                    { 398L, "Instrument Supervisor" },
                    { 373L, "Housekeeper" },
                    { 372L, "Househusband" },
                    { 378L, "Hygienist" },
                    { 371L, "Hotelier" },
                    { 369L, "Hotel Consultant" },
                    { 368L, "Hot Foil Printer" },
                    { 367L, "Hostess" },
                    { 366L, "Hospital Worker" },
                    { 365L, "Hospital Warden" },
                    { 364L, "Hospital Technician" },
                    { 370L, "Hotel Worker" },
                    { 379L, "Hypnotherapist" },
                    { 374L, "Housewife" },
                    { 381L, "IT Consultant" },
                    { 396L, "Instrument Engineer" },
                    { 395L, "Instructor" },
                    { 380L, "Hypnotist" },
                    { 393L, "Injection Moulder" },
                    { 392L, "Industrial Consultant" },
                    { 391L, "Industrial Chemist" },
                    { 390L, "Induction Moulder" },
                    { 394L, "Inspector" },
                    { 388L, "Importer" },
                    { 387L, "Import Consultant" },
                    { 386L, "Immigration Officer" },
                    { 385L, "Illustrator" },
                    { 384L, "Ice Cream Vendor" },
                    { 383L, "IT Trainer" },
                    { 382L, "IT Manager" },
                    { 389L, "Independent Means" }
                });

            migrationBuilder.InsertData(
                table: "StarSigns",
                columns: new[] { "StarSignId", "EndDate", "Name", "StartDate" },
                values: new object[,]
                {
                    { 10L, new DateTime(1, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Scorpius", new DateTime(1, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9L, new DateTime(1, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Libra", new DateTime(1, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8L, new DateTime(1, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Virgo", new DateTime(1, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7L, new DateTime(1, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Leo", new DateTime(1, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6L, new DateTime(1, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cancer", new DateTime(1, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2L, new DateTime(1, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pisces", new DateTime(1, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4L, new DateTime(1, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Taurus", new DateTime(1, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3L, new DateTime(1, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aries", new DateTime(1, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1L, new DateTime(1, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aquarius", new DateTime(1, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11L, new DateTime(1, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sagiattarius", new DateTime(1, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5L, new DateTime(1, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gemini", new DateTime(1, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12L, new DateTime(1, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Capricornus", new DateTime(1, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_ProfessionId",
                table: "Users",
                column: "ProfessionId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_StarSignId",
                table: "Users",
                column: "StarSignId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Professions_ProfessionId",
                table: "Users",
                column: "ProfessionId",
                principalTable: "Professions",
                principalColumn: "ProfessionId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_StarSigns_StarSignId",
                table: "Users",
                column: "StarSignId",
                principalTable: "StarSigns",
                principalColumn: "StarSignId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
