import type { SearchResult } from "../types/SearchType";

// Temporär mockdata nedfanför
const YoutubeURL = "https://www.youtube.com/watch?v=fg2gLapBFow";
const PdfURL =
  "https://www.w3.org/WAI/ER/tests/xhtml/testfiles/resources/pdf/dummy.pdf";

const mockSearchResults: SearchResult[] = [
  {
    id: 1,
    type: "Youtube",
    title: "Hur man lagar en punktering",
    description: "Steg-for-steg guide till att byta slang på din cykel.",
    category: "Verkstad",
    URL: YoutubeURL,
  },
  {
    id: 2,
    type: "Youtube",
    title: "Bromsjustering - V-bromsar",
    description: "Video om hur du ställer in och justerar V-bromsar korrekt.",
    category: "Kassa",
    URL: YoutubeURL,
  },
  {
    id: 3,
    type: "Youtube",
    title: "Kedjesmörjning och skötsel",
    description: "Guide till regelbunden kedjesmörjning for längre livslängd.",
    category: "Säljhjälp",
    URL: YoutubeURL,
  },
  {
    id: 4,
    type: "PDF",
    title: "Monteringsmanual - Shimano växlar",
    description: "Officiell manual for montering av Shimano 7-växlat nav.",
    category: "Kassa",
    URL: PdfURL,
  },
  {
    id: 5,
    type: "PDF",
    title: "Formanscykel - handbok för arbetsgivare",
    description: "Allt du behover veta om att erbjuda formanscyklar.",
    category: "Frakt",
    URL: PdfURL,
  },
  {
    id: 6,
    type: "Youtube",
    title: "Snabbguide: däcktryck och ventiler",
    description: "Så väljer du rätt däcktryck for pendling och träning.",
    category: "Verkstad",
    URL: YoutubeURL,
  },
  {
    id: 8,
    type: "PDF",
    title: "Servicechecklista infor säsong",
    description:
      "Checklistan for genomgång av cyklar inför vår- och sommarsäsong.",
    category: "Handböcker",
    URL: PdfURL,
  },
  {
    id: 9,
    type: "PDF",
    title: "Servicechecklista infor säsong",
    description:
      "Checklistan for genomgång av cyklar infor vår- och sommarsäsong.",
    category: "Kassa",
    URL: PdfURL,
  },
  {
    id: 10,
    type: "PDF",
    title: "Servicechecklista inför säsong",
    description:
      "Checklistan for genomgång av cyklar infor vår- och sommarsäsong.",
    category: "Frakt",
    URL: PdfURL,
  },
  {
    id: 11,
    type: "PDF",
    title: "Servicechecklista infor säsong",
    description:
      "Checklistan för genomgång av cyklar infor vår- och sommarsäsong.",
    category: "Kommunikation",
    URL: PdfURL,
  },
  {
    id: 12,
    type: "PDF",
    title: "Servicechecklista infor säsong",
    description:
      "Checklistan för genomgång av cyklar info vår- och sommarsäsong.",
    category: "Handböcker",
    URL: PdfURL,
  },
  {
    id: 13,
    type: "PDF",
    title: "Servicechecklista infor säsong",
    description:
      "Checklistan för genomgang av cyklar infor vår- och sommarsäsong.",
    category: "Frakt",
    URL: PdfURL,
  },
  {
    id: 14,
    type: "PDF",
    title: "Servicechecklista infor säsong",
    description:
      "Checklistan för genomgång av cyklar info vår- och sommarsäsong.",
    category: "Handböcker",
    URL: PdfURL,
  },
  {
    id: 15,
    type: "Youtube",
    title: "Servsgfddfg",
    description:
      "Checklistan för genomgång av cyklar info vår- och sommarsäsong.",
    category: "Kassa",
    URL: YoutubeURL,
  },
  {
    id: 16,
    type: "PDF",
    title: "Servidsfggfdadfgr säsong",
    description: "Checklistadsgadsfgav cyklar infor vår- och sommarsäsong.",
    category: "Kassa",
    URL: PdfURL,
  },
  {
    id: 17,
    type: "PDF",
    title: "Serviasdggdsa infor säsong",
    description:
      "Checklistan for genomgång av cyklar infor vår- och sommarsäsong.",
    category: "Kommunikation",
    URL: PdfURL,
  },
  {
    id: 18,
    type: "Youtube",
    title: "Servicasdgsdagista infor säsong",
    description:
      "Checklistan for genomgång av cyklar info vår- och sommarsäsong.",
    category: "Kommunikation",
    URL: YoutubeURL,
  },
  {
    id: 19,
    type: "Youtube",
    title: "Servicasdgsgdng",
    description:
      "Checklistan för genomgång av cyklar info vår- och sommarsäsong.",
    category: "Handböcker",
    URL: YoutubeURL,
  },
  {
    id: 20,
    type: "Youtube",
    title: "Servaasgdgdsdsgsasong",
    description: "Checklistan foasdgsgdsginfor vår- och sommarsäsong.",
    category: "Kassa",
    URL: YoutubeURL,
  },
];

export const getSearchResults = async (): Promise<SearchResult[]> => {
  return mockSearchResults;
};
