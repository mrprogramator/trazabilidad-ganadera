--
-- PostgreSQL database dump
--

-- Dumped from database version 9.4.2
-- Dumped by pg_dump version 9.4.2
-- Started on 2015-06-03 13:07:35

SET statement_timeout = 0;
SET lock_timeout = 0;
SET client_encoding = 'SQL_ASCII';
SET standard_conforming_strings = on;
SET check_function_bodies = false;
SET client_min_messages = warning;

--
-- TOC entry 200 (class 3079 OID 11855)
-- Name: plpgsql; Type: EXTENSION; Schema: -; Owner: 
--

CREATE EXTENSION IF NOT EXISTS plpgsql WITH SCHEMA pg_catalog;


--
-- TOC entry 2168 (class 0 OID 0)
-- Dependencies: 200
-- Name: EXTENSION plpgsql; Type: COMMENT; Schema: -; Owner: 
--

COMMENT ON EXTENSION plpgsql IS 'PL/pgSQL procedural language';


SET search_path = public, pg_catalog;

SET default_tablespace = '';

SET default_with_oids = false;

--
-- TOC entry 172 (class 1259 OID 16395)
-- Name: bovino; Type: TABLE; Schema: public; Owner: ganaderia; Tablespace: 
--

CREATE TABLE bovino (
    id integer NOT NULL,
    madre_id integer,
    padre_id integer,
    categoria_id integer,
    entrada date,
    salida date
);


ALTER TABLE bovino OWNER TO ganaderia;

--
-- TOC entry 173 (class 1259 OID 16398)
-- Name: bovino_id_seq; Type: SEQUENCE; Schema: public; Owner: ganaderia
--

CREATE SEQUENCE bovino_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE bovino_id_seq OWNER TO ganaderia;

--
-- TOC entry 2169 (class 0 OID 0)
-- Dependencies: 173
-- Name: bovino_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: ganaderia
--

ALTER SEQUENCE bovino_id_seq OWNED BY bovino.id;


--
-- TOC entry 174 (class 1259 OID 16400)
-- Name: categoria; Type: TABLE; Schema: public; Owner: ganaderia; Tablespace: 
--

CREATE TABLE categoria (
    id integer NOT NULL,
    nombre text,
    descripcion text,
    sexo text
);


ALTER TABLE categoria OWNER TO ganaderia;

--
-- TOC entry 175 (class 1259 OID 16406)
-- Name: categoria_id_seq; Type: SEQUENCE; Schema: public; Owner: ganaderia
--

CREATE SEQUENCE categoria_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE categoria_id_seq OWNER TO ganaderia;

--
-- TOC entry 2170 (class 0 OID 0)
-- Dependencies: 175
-- Name: categoria_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: ganaderia
--

ALTER SEQUENCE categoria_id_seq OWNED BY categoria.id;


--
-- TOC entry 176 (class 1259 OID 16408)
-- Name: compra; Type: TABLE; Schema: public; Owner: ganaderia; Tablespace: 
--

CREATE TABLE compra (
    id integer NOT NULL,
    bovino_id integer,
    fecha date,
    observaciones text,
    precio numeric
);


ALTER TABLE compra OWNER TO ganaderia;

--
-- TOC entry 177 (class 1259 OID 16414)
-- Name: compra_id_seq; Type: SEQUENCE; Schema: public; Owner: ganaderia
--

CREATE SEQUENCE compra_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE compra_id_seq OWNER TO ganaderia;

--
-- TOC entry 2171 (class 0 OID 0)
-- Dependencies: 177
-- Name: compra_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: ganaderia
--

ALTER SEQUENCE compra_id_seq OWNED BY compra.id;


--
-- TOC entry 178 (class 1259 OID 16416)
-- Name: estancia; Type: TABLE; Schema: public; Owner: ganaderia; Tablespace: 
--

CREATE TABLE estancia (
    id integer NOT NULL,
    nombre text,
    direccion text
);


ALTER TABLE estancia OWNER TO ganaderia;

--
-- TOC entry 179 (class 1259 OID 16422)
-- Name: estancia_id_seq; Type: SEQUENCE; Schema: public; Owner: ganaderia
--

CREATE SEQUENCE estancia_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE estancia_id_seq OWNER TO ganaderia;

--
-- TOC entry 2172 (class 0 OID 0)
-- Dependencies: 179
-- Name: estancia_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: ganaderia
--

ALTER SEQUENCE estancia_id_seq OWNED BY estancia.id;


--
-- TOC entry 180 (class 1259 OID 16424)
-- Name: inseminacion; Type: TABLE; Schema: public; Owner: ganaderia; Tablespace: 
--

CREATE TABLE inseminacion (
    id integer NOT NULL,
    fecha date,
    padre_id integer,
    madre_id integer,
    observaciones text
);


ALTER TABLE inseminacion OWNER TO ganaderia;

--
-- TOC entry 181 (class 1259 OID 16430)
-- Name: inseminacion_id_seq; Type: SEQUENCE; Schema: public; Owner: ganaderia
--

CREATE SEQUENCE inseminacion_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE inseminacion_id_seq OWNER TO ganaderia;

--
-- TOC entry 2173 (class 0 OID 0)
-- Dependencies: 181
-- Name: inseminacion_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: ganaderia
--

ALTER SEQUENCE inseminacion_id_seq OWNED BY inseminacion.id;


--
-- TOC entry 182 (class 1259 OID 16432)
-- Name: muerte; Type: TABLE; Schema: public; Owner: ganaderia; Tablespace: 
--

CREATE TABLE muerte (
    fecha date,
    bovino_id integer,
    causa text,
    id integer NOT NULL
);


ALTER TABLE muerte OWNER TO ganaderia;

--
-- TOC entry 183 (class 1259 OID 16438)
-- Name: muerte_id2_seq; Type: SEQUENCE; Schema: public; Owner: ganaderia
--

CREATE SEQUENCE muerte_id2_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE muerte_id2_seq OWNER TO ganaderia;

--
-- TOC entry 2174 (class 0 OID 0)
-- Dependencies: 183
-- Name: muerte_id2_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: ganaderia
--

ALTER SEQUENCE muerte_id2_seq OWNED BY muerte.id;


--
-- TOC entry 184 (class 1259 OID 16440)
-- Name: nacimiento; Type: TABLE; Schema: public; Owner: ganaderia; Tablespace: 
--

CREATE TABLE nacimiento (
    id integer NOT NULL,
    bovino_id integer,
    fecha date,
    observaciones text
);


ALTER TABLE nacimiento OWNER TO ganaderia;

--
-- TOC entry 185 (class 1259 OID 16446)
-- Name: nacimiento_id_seq; Type: SEQUENCE; Schema: public; Owner: ganaderia
--

CREATE SEQUENCE nacimiento_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE nacimiento_id_seq OWNER TO ganaderia;

--
-- TOC entry 2175 (class 0 OID 0)
-- Dependencies: 185
-- Name: nacimiento_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: ganaderia
--

ALTER SEQUENCE nacimiento_id_seq OWNED BY nacimiento.id;


--
-- TOC entry 186 (class 1259 OID 16448)
-- Name: palpacion; Type: TABLE; Schema: public; Owner: ganaderia; Tablespace: 
--

CREATE TABLE palpacion (
    id integer NOT NULL,
    fecha date,
    numero integer,
    mes_gestacion integer,
    estado boolean,
    bovino_id integer
);


ALTER TABLE palpacion OWNER TO ganaderia;

--
-- TOC entry 187 (class 1259 OID 16451)
-- Name: palpacion_id_seq; Type: SEQUENCE; Schema: public; Owner: ganaderia
--

CREATE SEQUENCE palpacion_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE palpacion_id_seq OWNER TO ganaderia;

--
-- TOC entry 2176 (class 0 OID 0)
-- Dependencies: 187
-- Name: palpacion_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: ganaderia
--

ALTER SEQUENCE palpacion_id_seq OWNED BY palpacion.id;


--
-- TOC entry 188 (class 1259 OID 16453)
-- Name: parto; Type: TABLE; Schema: public; Owner: ganaderia; Tablespace: 
--

CREATE TABLE parto (
    id integer NOT NULL,
    fecha date,
    resultado text,
    bovino_id integer,
    "preñado_id" integer,
    observaciones text
);


ALTER TABLE parto OWNER TO ganaderia;

--
-- TOC entry 189 (class 1259 OID 16459)
-- Name: parto_id_seq; Type: SEQUENCE; Schema: public; Owner: ganaderia
--

CREATE SEQUENCE parto_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE parto_id_seq OWNER TO ganaderia;

--
-- TOC entry 2177 (class 0 OID 0)
-- Dependencies: 189
-- Name: parto_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: ganaderia
--

ALTER SEQUENCE parto_id_seq OWNED BY parto.id;


--
-- TOC entry 190 (class 1259 OID 16461)
-- Name: peso; Type: TABLE; Schema: public; Owner: ganaderia; Tablespace: 
--

CREATE TABLE peso (
    id integer NOT NULL,
    fecha date,
    peso double precision,
    bovino_id integer
);


ALTER TABLE peso OWNER TO ganaderia;

--
-- TOC entry 191 (class 1259 OID 16464)
-- Name: peso_id_seq; Type: SEQUENCE; Schema: public; Owner: ganaderia
--

CREATE SEQUENCE peso_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE peso_id_seq OWNER TO ganaderia;

--
-- TOC entry 2178 (class 0 OID 0)
-- Dependencies: 191
-- Name: peso_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: ganaderia
--

ALTER SEQUENCE peso_id_seq OWNED BY peso.id;


--
-- TOC entry 192 (class 1259 OID 16466)
-- Name: preñado; Type: TABLE; Schema: public; Owner: ganaderia; Tablespace: 
--

CREATE TABLE "preñado" (
    id integer NOT NULL,
    fecha date,
    bovino_id integer,
    observaciones text
);


ALTER TABLE "preñado" OWNER TO ganaderia;

--
-- TOC entry 193 (class 1259 OID 16472)
-- Name: preñado_id_seq; Type: SEQUENCE; Schema: public; Owner: ganaderia
--

CREATE SEQUENCE "preñado_id_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE "preñado_id_seq" OWNER TO ganaderia;

--
-- TOC entry 2179 (class 0 OID 0)
-- Dependencies: 193
-- Name: preñado_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: ganaderia
--

ALTER SEQUENCE "preñado_id_seq" OWNED BY "preñado".id;


--
-- TOC entry 199 (class 1259 OID 16587)
-- Name: traza; Type: TABLE; Schema: public; Owner: ganaderia; Tablespace: 
--

CREATE TABLE traza (
    fecha date,
    bovino_id integer,
    categoria_id integer,
    id integer NOT NULL
);


ALTER TABLE traza OWNER TO ganaderia;

--
-- TOC entry 198 (class 1259 OID 16585)
-- Name: traza_id_seq; Type: SEQUENCE; Schema: public; Owner: ganaderia
--

CREATE SEQUENCE traza_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE traza_id_seq OWNER TO ganaderia;

--
-- TOC entry 2180 (class 0 OID 0)
-- Dependencies: 198
-- Name: traza_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: ganaderia
--

ALTER SEQUENCE traza_id_seq OWNED BY traza.id;


--
-- TOC entry 194 (class 1259 OID 16474)
-- Name: vacuna; Type: TABLE; Schema: public; Owner: ganaderia; Tablespace: 
--

CREATE TABLE vacuna (
    id integer NOT NULL,
    fecha date,
    bovino_id integer,
    nombre text,
    dosis numeric
);


ALTER TABLE vacuna OWNER TO ganaderia;

--
-- TOC entry 195 (class 1259 OID 16480)
-- Name: vacuna_id_seq; Type: SEQUENCE; Schema: public; Owner: ganaderia
--

CREATE SEQUENCE vacuna_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE vacuna_id_seq OWNER TO ganaderia;

--
-- TOC entry 2181 (class 0 OID 0)
-- Dependencies: 195
-- Name: vacuna_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: ganaderia
--

ALTER SEQUENCE vacuna_id_seq OWNED BY vacuna.id;


--
-- TOC entry 196 (class 1259 OID 16482)
-- Name: venta; Type: TABLE; Schema: public; Owner: ganaderia; Tablespace: 
--

CREATE TABLE venta (
    fecha date,
    bovino_id integer,
    destino text,
    precio numeric,
    observaciones text,
    id integer NOT NULL
);


ALTER TABLE venta OWNER TO ganaderia;

--
-- TOC entry 197 (class 1259 OID 16488)
-- Name: venta_id_seq; Type: SEQUENCE; Schema: public; Owner: ganaderia
--

CREATE SEQUENCE venta_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE venta_id_seq OWNER TO ganaderia;

--
-- TOC entry 2182 (class 0 OID 0)
-- Dependencies: 197
-- Name: venta_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: ganaderia
--

ALTER SEQUENCE venta_id_seq OWNED BY venta.id;


--
-- TOC entry 1969 (class 2604 OID 16490)
-- Name: id; Type: DEFAULT; Schema: public; Owner: ganaderia
--

ALTER TABLE ONLY bovino ALTER COLUMN id SET DEFAULT nextval('bovino_id_seq'::regclass);


--
-- TOC entry 1970 (class 2604 OID 16491)
-- Name: id; Type: DEFAULT; Schema: public; Owner: ganaderia
--

ALTER TABLE ONLY categoria ALTER COLUMN id SET DEFAULT nextval('categoria_id_seq'::regclass);


--
-- TOC entry 1971 (class 2604 OID 16492)
-- Name: id; Type: DEFAULT; Schema: public; Owner: ganaderia
--

ALTER TABLE ONLY compra ALTER COLUMN id SET DEFAULT nextval('compra_id_seq'::regclass);


--
-- TOC entry 1972 (class 2604 OID 16493)
-- Name: id; Type: DEFAULT; Schema: public; Owner: ganaderia
--

ALTER TABLE ONLY estancia ALTER COLUMN id SET DEFAULT nextval('estancia_id_seq'::regclass);


--
-- TOC entry 1973 (class 2604 OID 16494)
-- Name: id; Type: DEFAULT; Schema: public; Owner: ganaderia
--

ALTER TABLE ONLY inseminacion ALTER COLUMN id SET DEFAULT nextval('inseminacion_id_seq'::regclass);


--
-- TOC entry 1974 (class 2604 OID 16495)
-- Name: id; Type: DEFAULT; Schema: public; Owner: ganaderia
--

ALTER TABLE ONLY muerte ALTER COLUMN id SET DEFAULT nextval('muerte_id2_seq'::regclass);


--
-- TOC entry 1975 (class 2604 OID 16496)
-- Name: id; Type: DEFAULT; Schema: public; Owner: ganaderia
--

ALTER TABLE ONLY nacimiento ALTER COLUMN id SET DEFAULT nextval('nacimiento_id_seq'::regclass);


--
-- TOC entry 1976 (class 2604 OID 16497)
-- Name: id; Type: DEFAULT; Schema: public; Owner: ganaderia
--

ALTER TABLE ONLY palpacion ALTER COLUMN id SET DEFAULT nextval('palpacion_id_seq'::regclass);


--
-- TOC entry 1977 (class 2604 OID 16498)
-- Name: id; Type: DEFAULT; Schema: public; Owner: ganaderia
--

ALTER TABLE ONLY parto ALTER COLUMN id SET DEFAULT nextval('parto_id_seq'::regclass);


--
-- TOC entry 1978 (class 2604 OID 16499)
-- Name: id; Type: DEFAULT; Schema: public; Owner: ganaderia
--

ALTER TABLE ONLY peso ALTER COLUMN id SET DEFAULT nextval('peso_id_seq'::regclass);


--
-- TOC entry 1979 (class 2604 OID 16500)
-- Name: id; Type: DEFAULT; Schema: public; Owner: ganaderia
--

ALTER TABLE ONLY "preñado" ALTER COLUMN id SET DEFAULT nextval('"preñado_id_seq"'::regclass);


--
-- TOC entry 1982 (class 2604 OID 16590)
-- Name: id; Type: DEFAULT; Schema: public; Owner: ganaderia
--

ALTER TABLE ONLY traza ALTER COLUMN id SET DEFAULT nextval('traza_id_seq'::regclass);


--
-- TOC entry 1980 (class 2604 OID 16501)
-- Name: id; Type: DEFAULT; Schema: public; Owner: ganaderia
--

ALTER TABLE ONLY vacuna ALTER COLUMN id SET DEFAULT nextval('vacuna_id_seq'::regclass);


--
-- TOC entry 1981 (class 2604 OID 16502)
-- Name: id; Type: DEFAULT; Schema: public; Owner: ganaderia
--

ALTER TABLE ONLY venta ALTER COLUMN id SET DEFAULT nextval('venta_id_seq'::regclass);


--
-- TOC entry 2133 (class 0 OID 16395)
-- Dependencies: 172
-- Data for Name: bovino; Type: TABLE DATA; Schema: public; Owner: ganaderia
--

COPY bovino (id, madre_id, padre_id, categoria_id, entrada, salida) FROM stdin;
3	2	1	1	2015-06-03	\N
4	2	1	3	2015-06-03	\N
5	2	1	4	2015-06-03	\N
6	2	1	3	2015-06-03	\N
8	3	1	3	2015-06-03	\N
1	\N	\N	2	2015-06-03	\N
2	\N	\N	1	2015-06-03	\N
7	2	1	4	2015-06-03	2015-06-03
\.


--
-- TOC entry 2183 (class 0 OID 0)
-- Dependencies: 173
-- Name: bovino_id_seq; Type: SEQUENCE SET; Schema: public; Owner: ganaderia
--

SELECT pg_catalog.setval('bovino_id_seq', 8, true);


--
-- TOC entry 2135 (class 0 OID 16400)
-- Dependencies: 174
-- Data for Name: categoria; Type: TABLE DATA; Schema: public; Owner: ganaderia
--

COPY categoria (id, nombre, descripcion, sexo) FROM stdin;
1	vaca	ganado hembra	Hembra
4	vaquilla	ganado hembra joven	Hembra
3	novillo	ganado macho joven	Macho
2	toro	ganado macho	Macho
5	torillo	ganado macho joven adulto	Macho
\.


--
-- TOC entry 2184 (class 0 OID 0)
-- Dependencies: 175
-- Name: categoria_id_seq; Type: SEQUENCE SET; Schema: public; Owner: ganaderia
--

SELECT pg_catalog.setval('categoria_id_seq', 5, true);


--
-- TOC entry 2137 (class 0 OID 16408)
-- Dependencies: 176
-- Data for Name: compra; Type: TABLE DATA; Schema: public; Owner: ganaderia
--

COPY compra (id, bovino_id, fecha, observaciones, precio) FROM stdin;
1	1	2015-06-03	Compra de un toro	500
2	2	2015-06-03	Nació una vaca	500
\.


--
-- TOC entry 2185 (class 0 OID 0)
-- Dependencies: 177
-- Name: compra_id_seq; Type: SEQUENCE SET; Schema: public; Owner: ganaderia
--

SELECT pg_catalog.setval('compra_id_seq', 2, true);


--
-- TOC entry 2139 (class 0 OID 16416)
-- Dependencies: 178
-- Data for Name: estancia; Type: TABLE DATA; Schema: public; Owner: ganaderia
--

COPY estancia (id, nombre, direccion) FROM stdin;
1	cabalingo	Chiquitos
\.


--
-- TOC entry 2186 (class 0 OID 0)
-- Dependencies: 179
-- Name: estancia_id_seq; Type: SEQUENCE SET; Schema: public; Owner: ganaderia
--

SELECT pg_catalog.setval('estancia_id_seq', 1, true);


--
-- TOC entry 2141 (class 0 OID 16424)
-- Dependencies: 180
-- Data for Name: inseminacion; Type: TABLE DATA; Schema: public; Owner: ganaderia
--

COPY inseminacion (id, fecha, padre_id, madre_id, observaciones) FROM stdin;
2	2015-06-03	1	2	Se tienen altas expectativas
\.


--
-- TOC entry 2187 (class 0 OID 0)
-- Dependencies: 181
-- Name: inseminacion_id_seq; Type: SEQUENCE SET; Schema: public; Owner: ganaderia
--

SELECT pg_catalog.setval('inseminacion_id_seq', 2, true);


--
-- TOC entry 2143 (class 0 OID 16432)
-- Dependencies: 182
-- Data for Name: muerte; Type: TABLE DATA; Schema: public; Owner: ganaderia
--

COPY muerte (fecha, bovino_id, causa, id) FROM stdin;
2015-06-03	7	Picada de víbora	1
\.


--
-- TOC entry 2188 (class 0 OID 0)
-- Dependencies: 183
-- Name: muerte_id2_seq; Type: SEQUENCE SET; Schema: public; Owner: ganaderia
--

SELECT pg_catalog.setval('muerte_id2_seq', 1, true);


--
-- TOC entry 2145 (class 0 OID 16440)
-- Dependencies: 184
-- Data for Name: nacimiento; Type: TABLE DATA; Schema: public; Owner: ganaderia
--

COPY nacimiento (id, bovino_id, fecha, observaciones) FROM stdin;
6	7	2015-06-03	Nació con buena salud
1	3	2015-06-03	Nació una vaquilla
3	4	2015-06-03	Nació un novillo
4	5	2015-06-03	Nació muy flaca
5	6	2015-06-03	Nació pequeño
7	8	2015-06-03	Nació saludable
\.


--
-- TOC entry 2189 (class 0 OID 0)
-- Dependencies: 185
-- Name: nacimiento_id_seq; Type: SEQUENCE SET; Schema: public; Owner: ganaderia
--

SELECT pg_catalog.setval('nacimiento_id_seq', 7, true);


--
-- TOC entry 2147 (class 0 OID 16448)
-- Dependencies: 186
-- Data for Name: palpacion; Type: TABLE DATA; Schema: public; Owner: ganaderia
--

COPY palpacion (id, fecha, numero, mes_gestacion, estado, bovino_id) FROM stdin;
\.


--
-- TOC entry 2190 (class 0 OID 0)
-- Dependencies: 187
-- Name: palpacion_id_seq; Type: SEQUENCE SET; Schema: public; Owner: ganaderia
--

SELECT pg_catalog.setval('palpacion_id_seq', 8, true);


--
-- TOC entry 2149 (class 0 OID 16453)
-- Dependencies: 188
-- Data for Name: parto; Type: TABLE DATA; Schema: public; Owner: ganaderia
--

COPY parto (id, fecha, resultado, bovino_id, "preñado_id", observaciones) FROM stdin;
\.


--
-- TOC entry 2191 (class 0 OID 0)
-- Dependencies: 189
-- Name: parto_id_seq; Type: SEQUENCE SET; Schema: public; Owner: ganaderia
--

SELECT pg_catalog.setval('parto_id_seq', 1, true);


--
-- TOC entry 2151 (class 0 OID 16461)
-- Dependencies: 190
-- Data for Name: peso; Type: TABLE DATA; Schema: public; Owner: ganaderia
--

COPY peso (id, fecha, peso, bovino_id) FROM stdin;
\.


--
-- TOC entry 2192 (class 0 OID 0)
-- Dependencies: 191
-- Name: peso_id_seq; Type: SEQUENCE SET; Schema: public; Owner: ganaderia
--

SELECT pg_catalog.setval('peso_id_seq', 3, true);


--
-- TOC entry 2153 (class 0 OID 16466)
-- Dependencies: 192
-- Data for Name: preñado; Type: TABLE DATA; Schema: public; Owner: ganaderia
--

COPY "preñado" (id, fecha, bovino_id, observaciones) FROM stdin;
\.


--
-- TOC entry 2193 (class 0 OID 0)
-- Dependencies: 193
-- Name: preñado_id_seq; Type: SEQUENCE SET; Schema: public; Owner: ganaderia
--

SELECT pg_catalog.setval('"preñado_id_seq"', 1, true);


--
-- TOC entry 2160 (class 0 OID 16587)
-- Dependencies: 199
-- Data for Name: traza; Type: TABLE DATA; Schema: public; Owner: ganaderia
--

COPY traza (fecha, bovino_id, categoria_id, id) FROM stdin;
2015-06-03	1	2	1
2015-06-03	2	1	4
2015-06-03	5	4	37
2015-06-03	6	3	38
2015-06-03	7	4	39
2015-06-03	3	1	40
2013-03-14	3	4	13
2015-06-03	8	3	41
2015-06-03	4	3	28
\.


--
-- TOC entry 2194 (class 0 OID 0)
-- Dependencies: 198
-- Name: traza_id_seq; Type: SEQUENCE SET; Schema: public; Owner: ganaderia
--

SELECT pg_catalog.setval('traza_id_seq', 41, true);


--
-- TOC entry 2155 (class 0 OID 16474)
-- Dependencies: 194
-- Data for Name: vacuna; Type: TABLE DATA; Schema: public; Owner: ganaderia
--

COPY vacuna (id, fecha, bovino_id, nombre, dosis) FROM stdin;
2	2015-06-03	1	Antiparasitaria	1
3	2015-06-03	2	Antiparasitaria	1
4	2015-06-03	3	Antiparasitaria	1
5	2015-06-03	4	Antiparasitaria	1
6	2015-06-03	5	Antiparasitaria	1
7	2015-06-03	6	Antiparasitaria	1
8	2015-06-03	7	Antiparasitaria	1
\.


--
-- TOC entry 2195 (class 0 OID 0)
-- Dependencies: 195
-- Name: vacuna_id_seq; Type: SEQUENCE SET; Schema: public; Owner: ganaderia
--

SELECT pg_catalog.setval('vacuna_id_seq', 8, true);


--
-- TOC entry 2157 (class 0 OID 16482)
-- Dependencies: 196
-- Data for Name: venta; Type: TABLE DATA; Schema: public; Owner: ganaderia
--

COPY venta (fecha, bovino_id, destino, precio, observaciones, id) FROM stdin;
\.


--
-- TOC entry 2196 (class 0 OID 0)
-- Dependencies: 197
-- Name: venta_id_seq; Type: SEQUENCE SET; Schema: public; Owner: ganaderia
--

SELECT pg_catalog.setval('venta_id_seq', 1, false);


--
-- TOC entry 1986 (class 2606 OID 16504)
-- Name: pk_categoria; Type: CONSTRAINT; Schema: public; Owner: ganaderia; Tablespace: 
--

ALTER TABLE ONLY categoria
    ADD CONSTRAINT pk_categoria PRIMARY KEY (id);


--
-- TOC entry 1988 (class 2606 OID 16506)
-- Name: pk_compra; Type: CONSTRAINT; Schema: public; Owner: ganaderia; Tablespace: 
--

ALTER TABLE ONLY compra
    ADD CONSTRAINT pk_compra PRIMARY KEY (id);


--
-- TOC entry 1990 (class 2606 OID 16508)
-- Name: pk_estancia; Type: CONSTRAINT; Schema: public; Owner: ganaderia; Tablespace: 
--

ALTER TABLE ONLY estancia
    ADD CONSTRAINT pk_estancia PRIMARY KEY (id);


--
-- TOC entry 1984 (class 2606 OID 16510)
-- Name: pk_ganado; Type: CONSTRAINT; Schema: public; Owner: ganaderia; Tablespace: 
--

ALTER TABLE ONLY bovino
    ADD CONSTRAINT pk_ganado PRIMARY KEY (id);


--
-- TOC entry 1992 (class 2606 OID 16512)
-- Name: pk_inseminacion; Type: CONSTRAINT; Schema: public; Owner: ganaderia; Tablespace: 
--

ALTER TABLE ONLY inseminacion
    ADD CONSTRAINT pk_inseminacion PRIMARY KEY (id);


--
-- TOC entry 1994 (class 2606 OID 16514)
-- Name: pk_muerte; Type: CONSTRAINT; Schema: public; Owner: ganaderia; Tablespace: 
--

ALTER TABLE ONLY muerte
    ADD CONSTRAINT pk_muerte PRIMARY KEY (id);


--
-- TOC entry 1996 (class 2606 OID 16516)
-- Name: pk_nacimiento; Type: CONSTRAINT; Schema: public; Owner: ganaderia; Tablespace: 
--

ALTER TABLE ONLY nacimiento
    ADD CONSTRAINT pk_nacimiento PRIMARY KEY (id);


--
-- TOC entry 1998 (class 2606 OID 16518)
-- Name: pk_palpacion; Type: CONSTRAINT; Schema: public; Owner: ganaderia; Tablespace: 
--

ALTER TABLE ONLY palpacion
    ADD CONSTRAINT pk_palpacion PRIMARY KEY (id);


--
-- TOC entry 2000 (class 2606 OID 16520)
-- Name: pk_parto; Type: CONSTRAINT; Schema: public; Owner: ganaderia; Tablespace: 
--

ALTER TABLE ONLY parto
    ADD CONSTRAINT pk_parto PRIMARY KEY (id);


--
-- TOC entry 2002 (class 2606 OID 16522)
-- Name: pk_peso; Type: CONSTRAINT; Schema: public; Owner: ganaderia; Tablespace: 
--

ALTER TABLE ONLY peso
    ADD CONSTRAINT pk_peso PRIMARY KEY (id);


--
-- TOC entry 2004 (class 2606 OID 16524)
-- Name: pk_preñado; Type: CONSTRAINT; Schema: public; Owner: ganaderia; Tablespace: 
--

ALTER TABLE ONLY "preñado"
    ADD CONSTRAINT "pk_preñado" PRIMARY KEY (id);


--
-- TOC entry 2010 (class 2606 OID 16592)
-- Name: pk_traza; Type: CONSTRAINT; Schema: public; Owner: ganaderia; Tablespace: 
--

ALTER TABLE ONLY traza
    ADD CONSTRAINT pk_traza PRIMARY KEY (id);


--
-- TOC entry 2008 (class 2606 OID 16526)
-- Name: pk_venta; Type: CONSTRAINT; Schema: public; Owner: ganaderia; Tablespace: 
--

ALTER TABLE ONLY venta
    ADD CONSTRAINT pk_venta PRIMARY KEY (id);


--
-- TOC entry 2006 (class 2606 OID 16528)
-- Name: vacuna_pkey; Type: CONSTRAINT; Schema: public; Owner: ganaderia; Tablespace: 
--

ALTER TABLE ONLY vacuna
    ADD CONSTRAINT vacuna_pkey PRIMARY KEY (id);


--
-- TOC entry 2022 (class 2606 OID 16593)
-- Name: fk_bovino; Type: FK CONSTRAINT; Schema: public; Owner: ganaderia
--

ALTER TABLE ONLY traza
    ADD CONSTRAINT fk_bovino FOREIGN KEY (bovino_id) REFERENCES bovino(id);


--
-- TOC entry 2011 (class 2606 OID 16529)
-- Name: fk_categoria; Type: FK CONSTRAINT; Schema: public; Owner: ganaderia
--

ALTER TABLE ONLY bovino
    ADD CONSTRAINT fk_categoria FOREIGN KEY (categoria_id) REFERENCES categoria(id);


--
-- TOC entry 2023 (class 2606 OID 16598)
-- Name: fk_categoria; Type: FK CONSTRAINT; Schema: public; Owner: ganaderia
--

ALTER TABLE ONLY traza
    ADD CONSTRAINT fk_categoria FOREIGN KEY (categoria_id) REFERENCES categoria(id);


--
-- TOC entry 2015 (class 2606 OID 16534)
-- Name: fk_ganado; Type: FK CONSTRAINT; Schema: public; Owner: ganaderia
--

ALTER TABLE ONLY nacimiento
    ADD CONSTRAINT fk_ganado FOREIGN KEY (bovino_id) REFERENCES bovino(id);


--
-- TOC entry 2012 (class 2606 OID 16539)
-- Name: fk_ganado; Type: FK CONSTRAINT; Schema: public; Owner: ganaderia
--

ALTER TABLE ONLY compra
    ADD CONSTRAINT fk_ganado FOREIGN KEY (bovino_id) REFERENCES bovino(id);


--
-- TOC entry 2016 (class 2606 OID 16544)
-- Name: fk_ganado; Type: FK CONSTRAINT; Schema: public; Owner: ganaderia
--

ALTER TABLE ONLY palpacion
    ADD CONSTRAINT fk_ganado FOREIGN KEY (bovino_id) REFERENCES bovino(id);


--
-- TOC entry 2017 (class 2606 OID 16549)
-- Name: fk_ganado; Type: FK CONSTRAINT; Schema: public; Owner: ganaderia
--

ALTER TABLE ONLY parto
    ADD CONSTRAINT fk_ganado FOREIGN KEY (bovino_id) REFERENCES bovino(id);


--
-- TOC entry 2019 (class 2606 OID 16554)
-- Name: fk_ganado; Type: FK CONSTRAINT; Schema: public; Owner: ganaderia
--

ALTER TABLE ONLY peso
    ADD CONSTRAINT fk_ganado FOREIGN KEY (bovino_id) REFERENCES bovino(id);


--
-- TOC entry 2013 (class 2606 OID 16559)
-- Name: fk_madre; Type: FK CONSTRAINT; Schema: public; Owner: ganaderia
--

ALTER TABLE ONLY inseminacion
    ADD CONSTRAINT fk_madre FOREIGN KEY (madre_id) REFERENCES bovino(id);


--
-- TOC entry 2014 (class 2606 OID 16564)
-- Name: fk_padre; Type: FK CONSTRAINT; Schema: public; Owner: ganaderia
--

ALTER TABLE ONLY inseminacion
    ADD CONSTRAINT fk_padre FOREIGN KEY (padre_id) REFERENCES bovino(id);


--
-- TOC entry 2018 (class 2606 OID 16569)
-- Name: fk_preñado; Type: FK CONSTRAINT; Schema: public; Owner: ganaderia
--

ALTER TABLE ONLY parto
    ADD CONSTRAINT "fk_preñado" FOREIGN KEY ("preñado_id") REFERENCES "preñado"(id);


--
-- TOC entry 2020 (class 2606 OID 16574)
-- Name: fk_vaca; Type: FK CONSTRAINT; Schema: public; Owner: ganaderia
--

ALTER TABLE ONLY "preñado"
    ADD CONSTRAINT fk_vaca FOREIGN KEY (bovino_id) REFERENCES bovino(id);


--
-- TOC entry 2021 (class 2606 OID 16579)
-- Name: vacuna_bovino_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: ganaderia
--

ALTER TABLE ONLY vacuna
    ADD CONSTRAINT vacuna_bovino_id_fkey FOREIGN KEY (bovino_id) REFERENCES bovino(id);


--
-- TOC entry 2167 (class 0 OID 0)
-- Dependencies: 6
-- Name: public; Type: ACL; Schema: -; Owner: postgres
--

REVOKE ALL ON SCHEMA public FROM PUBLIC;
REVOKE ALL ON SCHEMA public FROM postgres;
GRANT ALL ON SCHEMA public TO postgres;
GRANT ALL ON SCHEMA public TO PUBLIC;


-- Completed on 2015-06-03 13:07:36

--
-- PostgreSQL database dump complete
--

