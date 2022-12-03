using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class AddImageAndTrailer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Games",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Trailer",
                table: "Games",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Image", "Trailer" },
                values: new object[] { "https://www.google.com/imgres?imgurl=https%3A%2F%2Fgrywator.pl%2Fwp-content%2Fuploads%2F2021%2F09%2FHpl5MtwQgOVF9vJqlfui6SDB5Jl4oBSq.jpg&imgrefurl=https%3A%2F%2Fgrywator.pl%2Fproduct%2Fred-dead-redemption-2-steam-pc-grywator-pl%2F&tbnid=a5B_3gt-lNWK5M&vet=12ahUKEwjjquCqlLP7AhXsiIsKHYWxBNwQMygDegUIARDGAQ..i&docid=KZ34ZrGCEVpwIM&w=1024&h=1024&q=red%20dead%20redemption%202%20image&client=opera-gx&ved=2ahUKEwjjquCqlLP7AhXsiIsKHYWxBNwQMygDegUIARDGAQ", "https://www.youtube.com/watch?v=eaW0tYpxyp0&t=36s" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Image", "Trailer" },
                values: new object[] { "https://www.google.com/imgres?imgurl=https%3A%2F%2Fimage.jeuxvideo.com%2Fmedias-sm%2F163129%2F1631287693-8700-jaquette-avant.jpg&imgrefurl=https%3A%2F%2Fwww.jeuxvideo.com%2Fjeux%2Fjeu-73734%2F&tbnid=7IgtprZVlxbhbM&vet=12ahUKEwjpg6WLlbP7AhXL6CoKHdMfDowQMygHegUIARDTAQ..i&docid=z2suqqzd6eml9M&w=480&h=640&q=gta%205%20image&client=opera-gx&ved=2ahUKEwjpg6WLlbP7AhXL6CoKHdMfDowQMygHegUIARDTAQ", "https://www.youtube.com/watch?v=QkkoHAzjnUs&t=11s" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Image", "Trailer" },
                values: new object[] { "https://www.google.com/imgres?imgurl=https%3A%2F%2Fcdn.akamai.steamstatic.com%2Fsteam%2Fapps%2F20900%2Fcapsule_616x353.jpg%3Ft%3D1659616192&imgrefurl=https%3A%2F%2Fstore.steampowered.com%2Fapp%2F20900%2FThe_Witcher_Enhanced_Edition_Directors_Cut%2F%3Fl%3Dpolish&tbnid=zV1irJolzWv5vM&vet=12ahUKEwj2ye7KlbP7AhUHgosKHeBeDZ8QMygAegUIARDHAQ..i&docid=iAJ0Aop4noPp-M&w=616&h=353&q=The%20Withcer%20Enhunced%20Edition%20image&client=opera-gx&ved=2ahUKEwj2ye7KlbP7AhUHgosKHeBeDZ8QMygAegUIARDHAQ", "https://www.youtube.com/watch?v=m3EF-71dodo" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Image", "Trailer" },
                values: new object[] { "https://www.google.com/imgres?imgurl=https%3A%2F%2Fm.media-amazon.com%2Fimages%2FM%2FMV5BMTUxODQyNjYtNmJkMS00MDg0LTgxNmItYzdkZjcwZDY3NWI1XkEyXkFqcGdeQXVyMTA0MTM5NjI2._V1_FMjpg_UX1000_.jpg&imgrefurl=https%3A%2F%2Fwww.imdb.com%2Ftitle%2Ftt0338221%2F&tbnid=CkUBDvoYNtLGgM&vet=12ahUKEwjqyaaWlrP7AhWvpYsKHffqD8cQMygEegUIARDAAQ..i&docid=6XXeOS0Gep1h1M&w=1000&h=1500&q=Mafia%3A%20The%20City%20of%20Lost%20Heaven%20image&client=opera-gx&ved=2ahUKEwjqyaaWlrP7AhWvpYsKHffqD8cQMygEegUIARDAAQ", "https://www.youtube.com/watch?v=b0lyjl27jFE" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 5,
                column: "Image",
                value: "https://www.google.com/imgres?imgurl=https%3A%2F%2Fplay-lh.googleusercontent.com%2FMumkEpSL7dj16Rt_JfqgKPmMhaWlBhQN5HD2sxNpCgKhUEiIkfcktW_pllWM3wfKeQ&imgrefurl=https%3A%2F%2Fplay.google.com%2Fstore%2Fapps%2Fdetails%3Fid%3Dio.wallpaperengine.weclient%26hl%3Dpl%26gl%3DUS&tbnid=Qfj-asQWHdRnUM&vet=12ahUKEwjx98uQl7P7AhVMiIsKHb-mD8cQMygGegUIARDMAQ..i&docid=kkUos20VbP66HM&w=512&h=512&q=Wallpaper%20Engien%20image&client=opera-gx&ved=2ahUKEwjx98uQl7P7AhVMiIsKHb-mD8cQMygGegUIARDMAQ");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Image", "Trailer" },
                values: new object[] { "https://www.google.com/imgres?imgurl=https%3A%2F%2Fupload.wikimedia.org%2Fwikipedia%2Fen%2Fe%2Fe4%2FGetting_Up.jpg&imgrefurl=https%3A%2F%2Fen.wikipedia.org%2Fwiki%2FMarc_Ecko%2527s_Getting_Up%3A_Contents_Under_Pressure&tbnid=M2-8usfMMC95NM&vet=12ahUKEwjxvY7Rl7P7AhWBlosKHVFRAFcQMygAegUIARC_AQ..i&docid=EYPpOINyFLZufM&w=267&h=373&q=Marc%20Eck%C5%8D%27s%20Getting%20Up%3A%20Contents%20Under%20Pressure%20image&client=opera-gx&ved=2ahUKEwjxvY7Rl7P7AhWBlosKHVFRAFcQMygAegUIARC_AQ", "https://www.youtube.com/watch?v=1EREQPdHp0w" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Image", "Trailer" },
                values: new object[] { "https://www.google.com/imgres?imgurl=https%3A%2F%2Ff.allegroimg.com%2Fs512%2F03f36b%2F939fb3ce46ee98850070c1e89a2f%2FEURO-TRUCK-SIMULATOR-2-PL-STEAM-ETS-2-GRATIS&imgrefurl=https%3A%2F%2Fallegro.pl%2Foferta%2Feuro-truck-simulator-2-pl-steam-ets-2-gratis-7763179987&tbnid=Kg7ZIuVD2sfNqM&vet=12ahUKEwjBzuOomLP7AhVUDBAIHbLACz8QMygCegUIARDNAQ..i&docid=UGTzcS_8EDKd2M&w=460&h=215&q=ets%202%20image&client=opera-gx&ved=2ahUKEwjBzuOomLP7AhVUDBAIHbLACz8QMygCegUIARDNAQ", "https://www.youtube.com/watch?v=xlTuC18xVII" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Image", "Trailer" },
                values: new object[] { "https://www.google.com/imgres?imgurl=https%3A%2F%2Fsavegame.pro%2Fwp-content%2Fuploads%2F2020%2F04%2Fthe-witcher-2-assassins-of-kings-enhanced-edition-cover.jpg&imgrefurl=https%3A%2F%2Fsavegame.pro%2Fpc-the-witcher-2-assassins-of-kings-enhanced-edition-savegame%2F&tbnid=n2G2BixgeJd8kM&vet=12ahUKEwizxJ6TmbP7AhUFmIsKHSe3ASEQMygIegUIARDYAQ..i&docid=onnju3YooLGWWM&w=300&h=300&q=The%20Witcher%202%3A%20Assassins%20of%20Kings%20Enhanced%20Edition%20image&client=opera-gx&ved=2ahUKEwizxJ6TmbP7AhUFmIsKHSe3ASEQMygIegUIARDYAQ", "https://www.youtube.com/watch?v=IEgBseW52JE" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Image", "Trailer" },
                values: new object[] { "https://www.google.com/imgres?imgurl=https%3A%2F%2Fupload.wikimedia.org%2Fwikipedia%2Fen%2Fthumb%2F0%2F0c%2FWitcher_3_cover_art.jpg%2F220px-Witcher_3_cover_art.jpg&imgrefurl=https%3A%2F%2Fen.wikipedia.org%2Fwiki%2FThe_Witcher_3%3A_Wild_Hunt&tbnid=zDecnt3f6d1lqM&vet=12ahUKEwisjtDombP7AhWFuIsKHdJEA3UQMygAegUIARDGAQ..i&docid=vS1DhpR2weCqPM&w=220&h=330&itg=1&q=The%20Witcher%203%3A%20Wild%20Hunt%20image&client=opera-gx&ved=2ahUKEwisjtDombP7AhWFuIsKHdJEA3UQMygAegUIARDGAQ", "https://www.youtube.com/watch?v=c0i88t0Kacs" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Image", "Trailer" },
                values: new object[] { "https://www.google.com/imgres?imgurl=https%3A%2F%2Fstatic.wikia.nocookie.net%2Fcallofjuarez%2Fimages%2Fd%2Fdf%2FCall_of_Juarez_Gunslinger.jpg%2Frevision%2Flatest%3Fcb%3D20130518211613&imgrefurl=https%3A%2F%2Fcallofjuarez.fandom.com%2Fwiki%2FCall_of_Juarez%3A_Gunslinger&tbnid=IaacEgSIp8Mf_M&vet=12ahUKEwjCkePFmrP7AhVeBhAIHb-cDSAQMygEegUIARDJAQ..i&docid=zhpAlO_A5xOHXM&w=1555&h=2196&q=Call%20of%20Juarez%3A%20Gunslinger%20image&client=opera-gx&ved=2ahUKEwjCkePFmrP7AhVeBhAIHb-cDSAQMygEegUIARDJAQ", "https://www.youtube.com/watch?v=OHh2RHuswqA" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Image", "Trailer" },
                values: new object[] { "https://www.google.com/imgres?imgurl=https%3A%2F%2Fcdn.windowsreport.com%2Fwp-content%2Fuploads%2F2020%2F06%2FCSGO-packet-loss-1200x1200.jpg&imgrefurl=https%3A%2F%2Fwindowsreport.com%2Fcsgo-packet-loss%2F&tbnid=cNHVclvisutNqM&vet=12ahUKEwig_bCQm7P7AhWXsSoKHZf3Cq4QMygUegUIARDoAQ..i&docid=MF3s7lmLJ2-jVM&w=1200&h=1200&q=csgo%20image&client=opera-gx&ved=2ahUKEwig_bCQm7P7AhWXsSoKHZf3Cq4QMygUegUIARDoAQ", "https://www.youtube.com/watch?v=edYCtaNueQY" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Image", "Trailer" },
                values: new object[] { "https://www.google.com/imgres?imgurl=https%3A%2F%2Fs3.gaming-cdn.com%2Fimages%2Fproducts%2F5504%2Forig-fallback-v1%2Frebel-cops-pc-mac-game-steam-cover.jpg%3Fv%3D1651500912&imgrefurl=https%3A%2F%2Fwww.instant-gaming.com%2Fpl%2F5504-buy-rebel-cops-pc-mac-game-steam%2F&tbnid=Z0kaXLYysUZ7YM&vet=12ahUKEwjM1tKWnLP7AhXFzioKHeE4A1cQMygGegUIARC9AQ..i&docid=Qv3BWFBYvNduKM&w=500&h=713&itg=1&q=rebel%20cops%20image&client=opera-gx&ved=2ahUKEwjM1tKWnLP7AhXFzioKHeE4A1cQMygGegUIARC9AQ", "https://www.youtube.com/watch?v=WtvX2FOk8Ew" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Image", "Trailer" },
                values: new object[] { "https://www.google.com/imgres?imgurl=https%3A%2F%2Fstatic.wikia.nocookie.net%2Fintothelongdark%2Fimages%2F8%2F8d%2FThe_Long_Dark_Poster.jpg%2Frevision%2Flatest%3Fcb%3D20171129011333&imgrefurl=https%3A%2F%2Fthelongdark.fandom.com%2Fwiki%2FThe_Long_Dark&tbnid=PdxD7O1I1o9E9M&vet=12ahUKEwie05G1nLP7AhWl-yoKHVnzDKoQMygKegUIARDYAQ..i&docid=8Ce-0hADtO7rGM&w=785&h=1024&q=The%20Long%20Dark%20image&client=opera-gx&ved=2ahUKEwie05G1nLP7AhWl-yoKHVnzDKoQMygKegUIARDYAQ", "https://www.youtube.com/watch?v=WJ-1O_w2KTg" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Image", "Trailer" },
                values: new object[] { "https://www.google.com/imgres?imgurl=https%3A%2F%2Fupload.wikimedia.org%2Fwikipedia%2Fen%2Fthumb%2F2%2F20%2FAmerican_Truck_Simulator_Steam_Cover.jpg%2F220px-American_Truck_Simulator_Steam_Cover.jpg&imgrefurl=https%3A%2F%2Fen.wikipedia.org%2Fwiki%2FAmerican_Truck_Simulator&tbnid=DYYsV3p61GaOzM&vet=12ahUKEwjQ35D8nLP7AhXLl4sKHZDTAY0QMygBegUIARDFAQ..i&docid=O5O9k779tlKPrM&w=220&h=330&q=america%20trakc%20simulator%20image&client=opera-gx&ved=2ahUKEwjQ35D8nLP7AhXLl4sKHZDTAY0QMygBegUIARDFAQ", "https://www.youtube.com/watch?v=Yu32OisFgWI" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "Trailer",
                table: "Games");
        }
    }
}
