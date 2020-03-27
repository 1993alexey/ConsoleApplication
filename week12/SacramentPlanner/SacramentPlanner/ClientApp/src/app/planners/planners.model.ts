export class Planners {
    constructor(
        public id: string,
        public wardName: string,
        public presiding: string,
        public conducting: string,
        public openingHymn: string,
        public invocation: string,
        public wardBusiness: string,
        public sacramentHymn: string,
        public sacramentPassing: boolean,
        public Talks: Planners[],
        public musicalNumber: string,
        public closingHymn: string,
        public benediction: string,
        public dismissalSong: string,
        public sacramentDate: string
    ) { }
}