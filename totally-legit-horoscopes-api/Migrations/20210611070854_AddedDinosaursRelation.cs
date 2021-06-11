﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace totally_legit_horoscopes_api.Migrations
{
    public partial class AddedDinosaursRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FavoriteDinosaurName",
                table: "Users",
                type: "text",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Dinosaurs",
                columns: table => new
                {
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dinosaurs", x => x.Name);
                });

            migrationBuilder.InsertData(
                table: "Dinosaurs",
                column: "Name",
                values: new object[]
                {
                    "Aardonyx",
                    "Pawpawsaurus",
                    "Pedopenna",
                    "Pegomastax",
                    "Pelecanimimus",
                    "Peloroplites",
                    "Pelorosaurus",
                    "Pentaceratops",
                    "Philovenator",
                    "Phuwiangosaurus",
                    "Piatnitzkysaurus",
                    "Pinacosaurus",
                    "Pisanosaurus",
                    "Piveteausaurus",
                    "Planicoxa",
                    "Plateosaurus",
                    "Pleurocoelus",
                    "Pneumatoraptor",
                    "Podokesaurus",
                    "Poekilopleuron",
                    "Patagosaurus",
                    "Parvicursor",
                    "Paronychodon",
                    "Parksosaurus",
                    "Othnielosaurus",
                    "Ouranosaurus",
                    "Overosaurus",
                    "Oviraptor",
                    "Oxalaia",
                    "Ozraptor",
                    "Pachycephalosaurus",
                    "Pachyrhinosaurus",
                    "Palaeoscincus",
                    "Polacanthus",
                    "Paluxysaurus",
                    "Pamparaptor",
                    "Panamericansaurus",
                    "Panoplosaurus",
                    "Panphagia",
                    "Pantydraco",
                    "Paralititan",
                    "Paranthodon",
                    "Pararhabdodon",
                    "Parasaurolophus",
                    "Pampadromaeus",
                    "Othnielia",
                    "Prenocephale",
                    "Proa",
                    "Regaliceratops",
                    "Regnosaurus",
                    "Rhabdodon",
                    "Rhinorex",
                    "Rhoetosaurus",
                    "Richardoestesia",
                    "Rinchenia",
                    "Rinconsaurus",
                    "Riojasaurus",
                    "Rubeosaurus",
                    "Rugops",
                    "Sahaliyania",
                    "Saichania",
                    "Saltasaurus",
                    "Saltopus",
                    "Sanjuansaurus",
                    "Santanaraptor",
                    "Sarahsaurus",
                    "Sarcolestes",
                    "Rebbachisaurus",
                    "Raptorex",
                    "Rapetosaurus",
                    "Rapator",
                    "Probactrosaurus",
                    "Proceratosaurus",
                    "Procompsognathus",
                    "Propanoplosaurus",
                    "Prosaurolophus",
                    "Protarchaeopteryx",
                    "Protoceratops",
                    "Protohadros",
                    "Psittacosaurus",
                    "Prenoceratops",
                    "Puertasaurus",
                    "Qantassaurus",
                    "Qianzhousaurus",
                    "Qiaowanlong",
                    "Qiupalong",
                    "Quaesitosaurus",
                    "Quilmesaurus",
                    "Rahiolisaurus",
                    "Rahonavis",
                    "Rajasaurus",
                    "Pyroraptor",
                    "Ostafrikasaurus",
                    "Oryctodromeus",
                    "Orthomerus",
                    "Masiakasaurus",
                    "Massospondylus",
                    "Maxakalisaurus",
                    "Medusaceratops",
                    "Megalosaurus",
                    "Megapnosaurus",
                    "Megaraptor",
                    "Mei",
                    "Melanorosaurus",
                    "Mendozasaurus",
                    "Mercuriceratops",
                    "Metriacanthosaurus",
                    "Microceratops",
                    "Micropachycephalosaurus",
                    "Microraptor",
                    "Microvenator",
                    "Minmi",
                    "Minotaurasaurus",
                    "Miragaia",
                    "Martharaptor",
                    "Marshosaurus",
                    "Mapusaurus",
                    "Mantellodon",
                    "Lourinhasaurus",
                    "Luanchuanraptor",
                    "Lufengosaurus",
                    "Lurdusaurus",
                    "Lusotitan",
                    "Lycorhinus",
                    "Lythronax",
                    "Machairasaurus",
                    "Macrogryphosaurus",
                    "Mirischia",
                    "Magnapaulia",
                    "Magnosaurus",
                    "Magyarosaurus",
                    "Mahakala",
                    "Maiasaura",
                    "Majungasaurus",
                    "Malawisaurus",
                    "Mamenchisaurus",
                    "Manidens",
                    "Mantellisaurus",
                    "Magnirostris",
                    "Mochlodon",
                    "Mojoceratops",
                    "Monkonosaurus",
                    "Noasaurus",
                    "Nodocephalosaurus",
                    "Nodosaurus",
                    "Nomingia",
                    "Nothronychus",
                    "Notohypsilophodon",
                    "Nqwebasaurus",
                    "Nuthetes",
                    "Nyasasaurus",
                    "Nipponosaurus",
                    "Ojoceratops",
                    "Omeisaurus",
                    "Oohkotokia",
                    "Opisthocoelicaudia",
                    "Orkoraptor",
                    "Ornithodesmus",
                    "Ornitholestes",
                    "Ornithomimus",
                    "Ornithopsis",
                    "Orodromeus",
                    "Olorotitan",
                    "Sarcosaurus",
                    "Nigersaurus",
                    "Neuquenraptor",
                    "Monoclonius",
                    "Monolophosaurus",
                    "Mononykus",
                    "Montanoceratops",
                    "Mussaurus",
                    "Muttaburrasaurus",
                    "Mymoorapelta",
                    "Nankangia",
                    "Nanosaurus",
                    "Neuquensaurus",
                    "Nanotyrannus",
                    "Nanuqsaurus",
                    "Nanyangosaurus",
                    "Nasutoceratops",
                    "Nebulasaurus",
                    "Nedcolbertia",
                    "Neimongosaurus",
                    "Nemegtomaia",
                    "Nemegtosaurus",
                    "Neovenator",
                    "Nanshiungosaurus",
                    "Lourinhanosaurus",
                    "Saturnalia",
                    "Sauroniops",
                    "Tyrannotitan",
                    "Uberabatitan",
                    "Udanoceratops",
                    "Unaysaurus",
                    "Unenlagia",
                    "Unescoceratops",
                    "Urbacodon",
                    "Utahceratops",
                    "Utahraptor",
                    "Uteodon",
                    "Vagaceratops",
                    "Vahiny",
                    "Valdoraptor",
                    "Valdosaurus",
                    "Variraptor",
                    "Velafrons",
                    "Velociraptor",
                    "Velocisaurus",
                    "Venenosaurus",
                    "Tyrannosaurus Rex",
                    "Tylocephale",
                    "Turiasaurus",
                    "Turanoceratops",
                    "Theiophytalia",
                    "Therizinosaurus",
                    "Thescelosaurus",
                    "Tianchisaurus",
                    "Tianyulong",
                    "Tianyuraptor",
                    "Tianzhenosaurus",
                    "Timimus",
                    "Titanoceratops",
                    "Veterupristisaurus",
                    "Titanosaurus",
                    "Tornieria",
                    "Torosaurus",
                    "Torvosaurus",
                    "Triceratops",
                    "Trinisaura",
                    "Troodon",
                    "Tsaagan",
                    "Tsintaosaurus",
                    "Tuojiangosaurus",
                    "Tochisaurus",
                    "Thecodontosaurus",
                    "Vulcanodon",
                    "Wellnhoferia",
                    "Yizhousaurus",
                    "Yongjinglong",
                    "Yueosaurus",
                    "Yulong",
                    "Yunnanosaurus",
                    "Yutyrannus",
                    "Zalmoxes",
                    "Zanabazar",
                    "Zapalasaurus",
                    "Zby",
                    "Zephyrosaurus",
                    "Zhanghenglong",
                    "Zhejiangosaurus",
                    "Zhenyuanlong",
                    "Zhongyuansaurus",
                    "Zhuchengceratops",
                    "Zhuchengosaurus",
                    "Zhuchengtyrannus",
                    "Zuniceratops",
                    "Yixianosaurus",
                    "Yinlong",
                    "Yimenosaurus",
                    "Yi Qi",
                    "Wendiceratops",
                    "Willinakaqe",
                    "Wintonotitan",
                    "Wuerhosaurus",
                    "Wulagasaurus",
                    "Xenoceratops",
                    "Xenoposeidon",
                    "Xenotarsosaurus",
                    "Xiaosaurus",
                    "Wannanosaurus",
                    "Xiaotingia",
                    "Xiongguanlong",
                    "Xixianykus",
                    "Xuanhanosaurus",
                    "Xuanhuaceratops",
                    "Xuwulong",
                    "Yamaceratops",
                    "Yandusaurus",
                    "Yangchuanosaurus",
                    "Yaverlandia",
                    "Xinjiangtitan",
                    "Thecocoelurus",
                    "Texacephale",
                    "Tethyshadros",
                    "Shunosaurus",
                    "Shuvosaurus",
                    "Shuvuuia",
                    "Siamodon",
                    "Siamosaurus",
                    "Siamotyrannus",
                    "Siats",
                    "Sigilmassasaurus",
                    "Silvisaurus",
                    "Similicaudipteryx",
                    "Sinocalliopteryx",
                    "Sinoceratops",
                    "Sinornithoides",
                    "Sinornithomimus",
                    "Sinornithosaurus",
                    "Sinosauropteryx",
                    "Sinosaurus",
                    "Sinotyrannus",
                    "Sinovenator",
                    "Shenzhousaurus",
                    "Shaochilong",
                    "Shantungosaurus",
                    "Shanag",
                    "Sauropelta",
                    "Saurophaganax",
                    "Sauroposeidon",
                    "Saurornithoides",
                    "Saurornitholestes",
                    "Savannasaurus",
                    "Scansoriopteryx",
                    "Scelidosaurus",
                    "Scipionyx",
                    "Sinraptor",
                    "Sciurumimus",
                    "Scutellosaurus",
                    "Secernosaurus",
                    "Seitaad",
                    "Segisaurus",
                    "Segnosaurus",
                    "Seismosaurus",
                    "Sellosaurus",
                    "Serendipaceratops",
                    "Shamosaurus",
                    "Scolosaurus",
                    "Sinusonasus",
                    "Skorpiovenator",
                    "Sonorasaurus",
                    "Tangvayosaurus",
                    "Tanius",
                    "Tanycolagreus",
                    "Taohelong",
                    "Tapuiasaurus",
                    "Tarascosaurus",
                    "Tarbosaurus",
                    "Tarchia",
                    "Tastavinsaurus",
                    "Talos",
                    "Tatankacephalus",
                    "Tataouinea",
                    "Tawa",
                    "Tazoudasaurus",
                    "Technosaurus",
                    "Tehuelchesaurus",
                    "Telmatosaurus",
                    "Tendaguria",
                    "Tenontosaurus",
                    "Teratophoneus",
                    "Tatankaceratops",
                    "Saurolophus",
                    "Talenkauen",
                    "Tachiraptor",
                    "Sphaerotholus",
                    "Spinophorosaurus",
                    "Spinops",
                    "Spinosaurus",
                    "Spinostropheus",
                    "Staurikosaurus",
                    "Stegoceras",
                    "Stegosaurus",
                    "Stenopelix",
                    "Talarurus",
                    "Stokesosaurus",
                    "Struthiosaurus",
                    "Stygimoloch",
                    "Styracosaurus",
                    "Suchomimus",
                    "Sulaimanisaurus",
                    "Supersaurus",
                    "Suuwassea",
                    "Suzhousaurus",
                    "Szechuanosaurus",
                    "Struthiomimus",
                    "Loricatosaurus",
                    "Lophostropheus",
                    "Lophorhothon",
                    "Brontomerus",
                    "Bruhathkayosaurus",
                    "Buitreraptor",
                    "Byronosaurus",
                    "Camarasaurus",
                    "Camarillasaurus",
                    "Camelotia",
                    "Camptosaurus",
                    "Carcharodontosaurus",
                    "Carnotaurus",
                    "Caudipteryx",
                    "Centrosaurus",
                    "Cerasinops",
                    "Ceratonykus",
                    "Ceratosaurus",
                    "Cetiosauriscus",
                    "Cetiosaurus",
                    "Changyuraptor",
                    "Chaoyangsaurus",
                    "Bravoceratops",
                    "Brachytrachelopan",
                    "Brachylophosaurus",
                    "Brachyceratops",
                    "Balaur",
                    "Bambiraptor",
                    "Barapasaurus",
                    "Barilium",
                    "Barosaurus",
                    "Barsboldia",
                    "Baryonyx",
                    "Batyrosaurus",
                    "Becklespinax",
                    "Charonosaurus",
                    "Beipiaosaurus",
                    "Bellusaurus",
                    "Berberosaurus",
                    "Bicentenaria",
                    "Bistahieversor",
                    "Bonapartenykus",
                    "Bonitasaura",
                    "Borogovia",
                    "Bothriospondylus",
                    "Brachiosaurus",
                    "Beishanlong",
                    "Bahariasaurus",
                    "Chasmosaurus",
                    "Chilantaisaurus",
                    "Dahalokely",
                    "Dakotaraptor",
                    "Daspletosaurus",
                    "Datousaurus",
                    "Darwinsaurus",
                    "Deinocheirus",
                    "Deinodon",
                    "Deinonychus",
                    "Delapparentia",
                    "Deltadromeus",
                    "Demandasaurus",
                    "Diabloceratops",
                    "Diamantinasaurus",
                    "Diceratops",
                    "Dicraeosaurus",
                    "Dilong",
                    "Dilophosaurus",
                    "Dimetrodon",
                    "Diplodocus",
                    "Daemonosaurus",
                    "Dacentrurus",
                    "Cumnoria",
                    "Cryptovolans",
                    "Chilesaurus",
                    "Chindesaurus",
                    "Chirostenotes",
                    "Chubutisaurus",
                    "Chungkingosaurus",
                    "Citipati",
                    "Claosaurus",
                    "Coahuilaceratops",
                    "Coelophysis",
                    "Chialingosaurus",
                    "Coelurus",
                    "Compsognathus",
                    "Concavenator",
                    "Conchoraptor",
                    "Condorraptor",
                    "Coronosaurus",
                    "Corythosaurus",
                    "Crichtonsaurus",
                    "Cruxicheiros",
                    "Cryolophosaurus",
                    "Colepiocephale",
                    "Bagaraatan",
                    "Bagaceratops",
                    "Bactrosaurus",
                    "Albalophosaurus",
                    "Albertaceratops",
                    "Albertadromeus",
                    "Albertonykus",
                    "Albertosaurus",
                    "Alectrosaurus",
                    "Aletopelta",
                    "Alioramus",
                    "Allosaurus",
                    "Altirhinus",
                    "Alvarezsaurus",
                    "Alwalkeria",
                    "Alxasaurus",
                    "Amargasaurus",
                    "Amazonsaurus",
                    "Ammosaurus",
                    "Ampelosaurus",
                    "Amphicoelias",
                    "Amurosaurus",
                    "Alaskacephale",
                    "Alamosaurus",
                    "Ajkaceratops",
                    "Agustinia",
                    "Abelisaurus",
                    "Abrictosaurus",
                    "Abrosaurus",
                    "Abydosaurus",
                    "Acanthopholis",
                    "Achelousaurus",
                    "Achillobator",
                    "Acristavus",
                    "Acrocanthosaurus",
                    "Anabisetia",
                    "Acrotholus",
                    "Adasaurus",
                    "Adeopapposaurus",
                    "Aegyptosaurus",
                    "Aeolosaurus",
                    "Aerosteon",
                    "Afrovenator",
                    "Agathaumas",
                    "Agilisaurus",
                    "Agujaceratops",
                    "Adamantisaurus",
                    "Anatosaurus",
                    "Anatotitan",
                    "Anchiceratops",
                    "Arcusaurus",
                    "Argentinosaurus",
                    "Argyrosaurus",
                    "Aristosuchus",
                    "Arrhinoceratops",
                    "Astrodon",
                    "Asylosaurus",
                    "Atlasaurus",
                    "Atlascopcosaurus",
                    "Arcovenator",
                    "Atrociraptor",
                    "Aucasaurus",
                    "Auroraceratops",
                    "Australodocus",
                    "Australovenator",
                    "Austroraptor",
                    "Austrosaurus",
                    "Avaceratops",
                    "Aviatyrannis",
                    "Avimimus",
                    "Aublysodon",
                    "Dollodon",
                    "Archaeornithomimus",
                    "Archaeoceratops",
                    "Anchiornis",
                    "Anchisaurus",
                    "Andesaurus",
                    "Angaturama",
                    "Angolatitan",
                    "Angulomastacator",
                    "Animantarx",
                    "Ankylosaurus",
                    "Anodontosaurus",
                    "Archaeopteryx",
                    "Anserimimus",
                    "Antarctosaurus",
                    "Antetonitrus",
                    "Anzu",
                    "Aorun",
                    "Apatosaurus",
                    "Appalachiosaurus",
                    "Aquilops",
                    "Aragosaurus",
                    "Aralosaurus",
                    "Antarctopelta",
                    "Draconyx",
                    "Dracopelta",
                    "Dracorex",
                    "Ignavusaurus",
                    "Iguanacolossus",
                    "Iguanodon",
                    "Ilokelesia",
                    "Incisivosaurus",
                    "Indosuchus",
                    "Ingenia",
                    "Irritator",
                    "Isanosaurus",
                    "Isisaurus",
                    "Jainosaurus",
                    "Janenschia",
                    "Jaxartosaurus",
                    "Jeholosaurus",
                    "Jeyawati",
                    "Jianchangosaurus",
                    "Jinfengopteryx",
                    "Jingshanosaurus",
                    "Jinzhousaurus",
                    "Ichthyovenator",
                    "Hypsilophodon",
                    "Hypsibema",
                    "Hypselospinus",
                    "Hesperosaurus",
                    "Heterodontosaurus",
                    "Hexing",
                    "Hexinlusaurus",
                    "Heyuannia",
                    "Hippodraco",
                    "Homalocephale",
                    "Hongshanosaurus",
                    "Hoplitosaurus",
                    "Jobaria",
                    "Huabeisaurus",
                    "Huaxiagnathus",
                    "Huaxiaosaurus",
                    "Huayangosaurus",
                    "Huehuecanauhtlus",
                    "Hungarosaurus",
                    "Huxleysaurus",
                    "Hylaeosaurus",
                    "Hypacrosaurus",
                    "Hypselosaurus",
                    "Huanghetitan",
                    "Judiceratops",
                    "Juratyrant",
                    "Juravenator",
                    "Lapparentosaurus",
                    "Laquintasaura",
                    "Latirhinus",
                    "Leaellynasaura",
                    "Leinkupal",
                    "Leonerasaurus",
                    "Leptoceratops",
                    "Leshansaurus",
                    "Lesothosaurus",
                    "Laosaurus",
                    "Lessemsaurus",
                    "Leyesaurus",
                    "Liaoceratops",
                    "Liaoningosaurus",
                    "Liliensternus",
                    "Limaysaurus",
                    "Limusaurus",
                    "Linhenykus",
                    "Linheraptor",
                    "Linhevenato",
                    "Lexovisaurus",
                    "Hesperonychus",
                    "Lanzhousaurus",
                    "Lambeosaurus",
                    "Kaatedocus",
                    "Kaijiangosaurus",
                    "Kazaklambia",
                    "Kentrosaurus",
                    "Kerberosaurus",
                    "Khaan",
                    "Kileskus",
                    "Kinnareemimus",
                    "Kol",
                    "Lamplughsaura",
                    "Koreaceratops",
                    "Kosmoceratops",
                    "Kotasaurus",
                    "Kritosaurus",
                    "Kryptops",
                    "Kukufeldia",
                    "Kulindadromeus",
                    "Kundurosaurus",
                    "Labocania",
                    "Lagosuchus",
                    "Koreanosaurus",
                    "Zuolong",
                    "Herrerasaurus",
                    "Harpymimus",
                    "Elopteryx",
                    "Elrhazosaurus",
                    "Enigmosaurus",
                    "Eoabelisaurus",
                    "Eobrontosaurus",
                    "Eocarcharia",
                    "Eocursor",
                    "Eodromaeus",
                    "Eolambia",
                    "Eoraptor",
                    "Eosinopteryx",
                    "Eotriceratops",
                    "Eotyrannus",
                    "Epachthosaurus",
                    "Epidendrosaurus",
                    "Epidexipteryx",
                    "Equijubus",
                    "Erectopus",
                    "Erketu",
                    "Elmisaurus",
                    "Elaphrosaurus",
                    "Ekrixinatosaurus",
                    "Einiosaurus",
                    "Dracovenator",
                    "Dravidosaurus",
                    "Dreadnoughtus",
                    "Drinker",
                    "Dromaeosauroides",
                    "Dromaeosaurus",
                    "Dromiceiomimus",
                    "Dryosaurus",
                    "Dryptosaurus",
                    "Erliansaurus",
                    "Dubreuillosaurus",
                    "Dyoplosaurus",
                    "Dysalotosaurus",
                    "Dyslocosaurus",
                    "Dystrophaeus",
                    "Echinodon",
                    "Edmarka",
                    "Edmontonia",
                    "Edmontosaurus",
                    "Efraasia",
                    "Duriavenator",
                    "Erlikosaurus",
                    "Euhelopus",
                    "Euoplocephalus",
                    "Giraffatitan",
                    "Glacialisaurus",
                    "Gobiceratops",
                    "Gobisaurus",
                    "Gobivenator",
                    "Gojirasaurus",
                    "Gondwanatitan",
                    "Gorgosaurus",
                    "Goyocephale",
                    "Gilmoreosaurus",
                    "Graciliraptor",
                    "Gryponyx",
                    "Gryposaurus",
                    "Guaibasaurus",
                    "Guanlong",
                    "Hadrosaurus",
                    "Hagryphus",
                    "Halticosaurus",
                    "Haplocanthosaurus",
                    "Haplocheirus",
                    "Gryphoceratops",
                    "Haya",
                    "Gigantspinosaurus",
                    "Giganotosaurus",
                    "Europasaurus",
                    "Europelta",
                    "Euskelosaurus",
                    "Eustreptospondylus",
                    "Fabrosaurus",
                    "Falcarius",
                    "Ferganasaurus",
                    "Fruitadens",
                    "Fukuiraptor",
                    "Gigantoraptor",
                    "Fukuisaurus",
                    "Futalognkosaurus",
                    "Gallimimus",
                    "Gargoyleosaurus",
                    "Garudimimus",
                    "Gasosaurus",
                    "Gasparinisaura",
                    "Gastonia",
                    "Genyodectes",
                    "Gideonmantellia",
                    "Fulgurotherium",
                    "Zupaysaurus"
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_FavoriteDinosaurName",
                table: "Users",
                column: "FavoriteDinosaurName");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Dinosaurs_FavoriteDinosaurName",
                table: "Users",
                column: "FavoriteDinosaurName",
                principalTable: "Dinosaurs",
                principalColumn: "Name",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Dinosaurs_FavoriteDinosaurName",
                table: "Users");

            migrationBuilder.DropTable(
                name: "Dinosaurs");

            migrationBuilder.DropIndex(
                name: "IX_Users_FavoriteDinosaurName",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "FavoriteDinosaurName",
                table: "Users");
        }
    }
}
