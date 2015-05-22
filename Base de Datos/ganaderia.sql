--
-- PostgreSQL database dump
--

-- Dumped from database version 9.4.1
-- Dumped by pg_dump version 9.4.1
-- Started on 2015-05-22 16:27:11 BOT

SET statement_timeout = 0;
SET lock_timeout = 0;
SET client_encoding = 'SQL_ASCII';
SET standard_conforming_strings = on;
SET check_function_bodies = false;
SET client_min_messages = warning;

--
-- TOC entry 196 (class 3079 OID 11862)
-- Name: plpgsql; Type: EXTENSION; Schema: -; Owner: 
--

CREATE EXTENSION IF NOT EXISTS plpgsql WITH SCHEMA pg_catalog;


--
-- TOC entry 2152 (class 0 OID 0)
-- Dependencies: 196
-- Name: EXTENSION plpgsql; Type: COMMENT; Schema: -; Owner: 
--

COMMENT ON EXTENSION plpgsql IS 'PL/pgSQL procedural language';


SET search_path = public, pg_catalog;

SET default_tablespace = '';

SET default_with_oids = false;

--
-- TOC entry 177 (class 1259 OID 25026)
-- Name: bovino; Type: TABLE; Schema: public; Owner: ganaderia; Tablespace: 
--

CREATE TABLE bovino (
    id integer NOT NULL,
    sexo "char",
    madre_id integer,
    padre_id integer,
    categoria_id integer,
    estancia_id integer,
    estado boolean
);


ALTER TABLE bovino OWNER TO ganaderia;

--
-- TOC entry 173 (class 1259 OID 25004)
-- Name: categoria; Type: TABLE; Schema: public; Owner: ganaderia; Tablespace: 
--

CREATE TABLE categoria (
    id integer NOT NULL,
    nombre text,
    descripcion text
);


ALTER TABLE categoria OWNER TO ganaderia;

--
-- TOC entry 172 (class 1259 OID 25002)
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
-- TOC entry 2153 (class 0 OID 0)
-- Dependencies: 172
-- Name: categoria_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: ganaderia
--

ALTER SEQUENCE categoria_id_seq OWNED BY categoria.id;


--
-- TOC entry 181 (class 1259 OID 25060)
-- Name: compra; Type: TABLE; Schema: public; Owner: ganaderia; Tablespace: 
--

CREATE TABLE compra (
    id integer NOT NULL,
    bovino_id integer,
    fecha date,
    observaciones text,
    precio double precision
);


ALTER TABLE compra OWNER TO ganaderia;

--
-- TOC entry 180 (class 1259 OID 25058)
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
-- TOC entry 2154 (class 0 OID 0)
-- Dependencies: 180
-- Name: compra_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: ganaderia
--

ALTER SEQUENCE compra_id_seq OWNED BY compra.id;


--
-- TOC entry 175 (class 1259 OID 25015)
-- Name: estancia; Type: TABLE; Schema: public; Owner: ganaderia; Tablespace: 
--

CREATE TABLE estancia (
    id integer NOT NULL,
    nombre text,
    direccion text
);


ALTER TABLE estancia OWNER TO ganaderia;

--
-- TOC entry 174 (class 1259 OID 25013)
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
-- TOC entry 2155 (class 0 OID 0)
-- Dependencies: 174
-- Name: estancia_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: ganaderia
--

ALTER SEQUENCE estancia_id_seq OWNED BY estancia.id;


--
-- TOC entry 176 (class 1259 OID 25024)
-- Name: ganado_id_seq; Type: SEQUENCE; Schema: public; Owner: ganaderia
--

CREATE SEQUENCE ganado_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE ganado_id_seq OWNER TO ganaderia;

--
-- TOC entry 2156 (class 0 OID 0)
-- Dependencies: 176
-- Name: ganado_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: ganaderia
--

ALTER SEQUENCE ganado_id_seq OWNED BY bovino.id;


--
-- TOC entry 183 (class 1259 OID 25076)
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
-- TOC entry 182 (class 1259 OID 25074)
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
-- TOC entry 2157 (class 0 OID 0)
-- Dependencies: 182
-- Name: inseminacion_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: ganaderia
--

ALTER SEQUENCE inseminacion_id_seq OWNED BY inseminacion.id;


--
-- TOC entry 193 (class 1259 OID 27252)
-- Name: muerte; Type: TABLE; Schema: public; Owner: ganaderia; Tablespace: 
--

CREATE TABLE muerte (
    id integer NOT NULL,
    fecha date,
    destino text,
    observaciones text,
    causa text,
    bovino_id integer
);


ALTER TABLE muerte OWNER TO ganaderia;

--
-- TOC entry 192 (class 1259 OID 27250)
-- Name: muerte_id_seq; Type: SEQUENCE; Schema: public; Owner: ganaderia
--

CREATE SEQUENCE muerte_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE muerte_id_seq OWNER TO ganaderia;

--
-- TOC entry 2158 (class 0 OID 0)
-- Dependencies: 192
-- Name: muerte_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: ganaderia
--

ALTER SEQUENCE muerte_id_seq OWNED BY muerte.id;


--
-- TOC entry 179 (class 1259 OID 25044)
-- Name: nacimiento; Type: TABLE; Schema: public; Owner: ganaderia; Tablespace: 
--

CREATE TABLE nacimiento (
    id integer NOT NULL,
    bovino_id integer,
    fecha date,
    observaciones text,
    parto_id integer
);


ALTER TABLE nacimiento OWNER TO ganaderia;

--
-- TOC entry 178 (class 1259 OID 25042)
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
-- TOC entry 2159 (class 0 OID 0)
-- Dependencies: 178
-- Name: nacimiento_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: ganaderia
--

ALTER SEQUENCE nacimiento_id_seq OWNED BY nacimiento.id;


--
-- TOC entry 185 (class 1259 OID 25097)
-- Name: palpacion; Type: TABLE; Schema: public; Owner: ganaderia; Tablespace: 
--

CREATE TABLE palpacion (
    id integer NOT NULL,
    fecha date,
    numero integer,
    mes_gestacion integer,
    estado boolean,
    observaciones text,
    bovino_id integer
);


ALTER TABLE palpacion OWNER TO ganaderia;

--
-- TOC entry 184 (class 1259 OID 25095)
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
-- TOC entry 2160 (class 0 OID 0)
-- Dependencies: 184
-- Name: palpacion_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: ganaderia
--

ALTER SEQUENCE palpacion_id_seq OWNED BY palpacion.id;


--
-- TOC entry 189 (class 1259 OID 25133)
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
-- TOC entry 188 (class 1259 OID 25131)
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
-- TOC entry 2161 (class 0 OID 0)
-- Dependencies: 188
-- Name: parto_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: ganaderia
--

ALTER SEQUENCE parto_id_seq OWNED BY parto.id;


--
-- TOC entry 191 (class 1259 OID 27239)
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
-- TOC entry 190 (class 1259 OID 27237)
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
-- TOC entry 2162 (class 0 OID 0)
-- Dependencies: 190
-- Name: peso_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: ganaderia
--

ALTER SEQUENCE peso_id_seq OWNED BY peso.id;


--
-- TOC entry 186 (class 1259 OID 25111)
-- Name: preñado; Type: TABLE; Schema: public; Owner: ganaderia; Tablespace: 
--

CREATE TABLE "preñado" (
    id integer NOT NULL,
    fecha date,
    ganado_id integer,
    observaciones text
);


ALTER TABLE "preñado" OWNER TO ganaderia;

--
-- TOC entry 187 (class 1259 OID 25114)
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
-- TOC entry 2163 (class 0 OID 0)
-- Dependencies: 187
-- Name: preñado_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: ganaderia
--

ALTER SEQUENCE "preñado_id_seq" OWNED BY "preñado".id;


--
-- TOC entry 195 (class 1259 OID 27268)
-- Name: venta; Type: TABLE; Schema: public; Owner: ganaderia; Tablespace: 
--

CREATE TABLE venta (
    id integer NOT NULL,
    fecha date,
    destino text,
    observaciones text,
    precio double precision,
    bovino_id integer
);


ALTER TABLE venta OWNER TO ganaderia;

--
-- TOC entry 194 (class 1259 OID 27266)
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
-- TOC entry 2164 (class 0 OID 0)
-- Dependencies: 194
-- Name: venta_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: ganaderia
--

ALTER SEQUENCE venta_id_seq OWNED BY venta.id;


--
-- TOC entry 1964 (class 2604 OID 25029)
-- Name: id; Type: DEFAULT; Schema: public; Owner: ganaderia
--

ALTER TABLE ONLY bovino ALTER COLUMN id SET DEFAULT nextval('ganado_id_seq'::regclass);


--
-- TOC entry 1962 (class 2604 OID 25007)
-- Name: id; Type: DEFAULT; Schema: public; Owner: ganaderia
--

ALTER TABLE ONLY categoria ALTER COLUMN id SET DEFAULT nextval('categoria_id_seq'::regclass);


--
-- TOC entry 1966 (class 2604 OID 25063)
-- Name: id; Type: DEFAULT; Schema: public; Owner: ganaderia
--

ALTER TABLE ONLY compra ALTER COLUMN id SET DEFAULT nextval('compra_id_seq'::regclass);


--
-- TOC entry 1963 (class 2604 OID 25018)
-- Name: id; Type: DEFAULT; Schema: public; Owner: ganaderia
--

ALTER TABLE ONLY estancia ALTER COLUMN id SET DEFAULT nextval('estancia_id_seq'::regclass);


--
-- TOC entry 1967 (class 2604 OID 25079)
-- Name: id; Type: DEFAULT; Schema: public; Owner: ganaderia
--

ALTER TABLE ONLY inseminacion ALTER COLUMN id SET DEFAULT nextval('inseminacion_id_seq'::regclass);


--
-- TOC entry 1972 (class 2604 OID 27255)
-- Name: id; Type: DEFAULT; Schema: public; Owner: ganaderia
--

ALTER TABLE ONLY muerte ALTER COLUMN id SET DEFAULT nextval('muerte_id_seq'::regclass);


--
-- TOC entry 1965 (class 2604 OID 25047)
-- Name: id; Type: DEFAULT; Schema: public; Owner: ganaderia
--

ALTER TABLE ONLY nacimiento ALTER COLUMN id SET DEFAULT nextval('nacimiento_id_seq'::regclass);


--
-- TOC entry 1968 (class 2604 OID 25100)
-- Name: id; Type: DEFAULT; Schema: public; Owner: ganaderia
--

ALTER TABLE ONLY palpacion ALTER COLUMN id SET DEFAULT nextval('palpacion_id_seq'::regclass);


--
-- TOC entry 1970 (class 2604 OID 25136)
-- Name: id; Type: DEFAULT; Schema: public; Owner: ganaderia
--

ALTER TABLE ONLY parto ALTER COLUMN id SET DEFAULT nextval('parto_id_seq'::regclass);


--
-- TOC entry 1971 (class 2604 OID 27242)
-- Name: id; Type: DEFAULT; Schema: public; Owner: ganaderia
--

ALTER TABLE ONLY peso ALTER COLUMN id SET DEFAULT nextval('peso_id_seq'::regclass);


--
-- TOC entry 1969 (class 2604 OID 25116)
-- Name: id; Type: DEFAULT; Schema: public; Owner: ganaderia
--

ALTER TABLE ONLY "preñado" ALTER COLUMN id SET DEFAULT nextval('"preñado_id_seq"'::regclass);


--
-- TOC entry 1973 (class 2604 OID 27271)
-- Name: id; Type: DEFAULT; Schema: public; Owner: ganaderia
--

ALTER TABLE ONLY venta ALTER COLUMN id SET DEFAULT nextval('venta_id_seq'::regclass);


--
-- TOC entry 2126 (class 0 OID 25026)
-- Dependencies: 177
-- Data for Name: bovino; Type: TABLE DATA; Schema: public; Owner: ganaderia
--

COPY bovino (id, sexo, madre_id, padre_id, categoria_id, estancia_id, estado) FROM stdin;
1	H	\N	\N	1	1	t
2	M	\N	\N	2	1	t
3	H	1	2	4	1	t
\.


--
-- TOC entry 2122 (class 0 OID 25004)
-- Dependencies: 173
-- Data for Name: categoria; Type: TABLE DATA; Schema: public; Owner: ganaderia
--

COPY categoria (id, nombre, descripcion) FROM stdin;
1	vaca	ganado hembra
2	toro	ganado macho
3	novillo	ganado macho joven
4	vaquilla	ganado hembra joven
\.


--
-- TOC entry 2165 (class 0 OID 0)
-- Dependencies: 172
-- Name: categoria_id_seq; Type: SEQUENCE SET; Schema: public; Owner: ganaderia
--

SELECT pg_catalog.setval('categoria_id_seq', 4, true);


--
-- TOC entry 2130 (class 0 OID 25060)
-- Dependencies: 181
-- Data for Name: compra; Type: TABLE DATA; Schema: public; Owner: ganaderia
--

COPY compra (id, bovino_id, fecha, observaciones, precio) FROM stdin;
1	1	2013-04-17	Compra de una vaca	500
2	2	2013-04-17	Compra de un toro	500
\.


--
-- TOC entry 2166 (class 0 OID 0)
-- Dependencies: 180
-- Name: compra_id_seq; Type: SEQUENCE SET; Schema: public; Owner: ganaderia
--

SELECT pg_catalog.setval('compra_id_seq', 2, true);


--
-- TOC entry 2124 (class 0 OID 25015)
-- Dependencies: 175
-- Data for Name: estancia; Type: TABLE DATA; Schema: public; Owner: ganaderia
--

COPY estancia (id, nombre, direccion) FROM stdin;
1	cabalingo	Chiquitos
\.


--
-- TOC entry 2167 (class 0 OID 0)
-- Dependencies: 174
-- Name: estancia_id_seq; Type: SEQUENCE SET; Schema: public; Owner: ganaderia
--

SELECT pg_catalog.setval('estancia_id_seq', 1, true);


--
-- TOC entry 2168 (class 0 OID 0)
-- Dependencies: 176
-- Name: ganado_id_seq; Type: SEQUENCE SET; Schema: public; Owner: ganaderia
--

SELECT pg_catalog.setval('ganado_id_seq', 4, true);


--
-- TOC entry 2132 (class 0 OID 25076)
-- Dependencies: 183
-- Data for Name: inseminacion; Type: TABLE DATA; Schema: public; Owner: ganaderia
--

COPY inseminacion (id, fecha, padre_id, madre_id, observaciones) FROM stdin;
1	2013-07-13	2	1	\N
\.


--
-- TOC entry 2169 (class 0 OID 0)
-- Dependencies: 182
-- Name: inseminacion_id_seq; Type: SEQUENCE SET; Schema: public; Owner: ganaderia
--

SELECT pg_catalog.setval('inseminacion_id_seq', 1, true);


--
-- TOC entry 2142 (class 0 OID 27252)
-- Dependencies: 193
-- Data for Name: muerte; Type: TABLE DATA; Schema: public; Owner: ganaderia
--

COPY muerte (id, fecha, destino, observaciones, causa, bovino_id) FROM stdin;
\.


--
-- TOC entry 2170 (class 0 OID 0)
-- Dependencies: 192
-- Name: muerte_id_seq; Type: SEQUENCE SET; Schema: public; Owner: ganaderia
--

SELECT pg_catalog.setval('muerte_id_seq', 1, false);


--
-- TOC entry 2128 (class 0 OID 25044)
-- Dependencies: 179
-- Data for Name: nacimiento; Type: TABLE DATA; Schema: public; Owner: ganaderia
--

COPY nacimiento (id, bovino_id, fecha, observaciones, parto_id) FROM stdin;
1	3	2014-05-18	\N	1
\.


--
-- TOC entry 2171 (class 0 OID 0)
-- Dependencies: 178
-- Name: nacimiento_id_seq; Type: SEQUENCE SET; Schema: public; Owner: ganaderia
--

SELECT pg_catalog.setval('nacimiento_id_seq', 4, true);


--
-- TOC entry 2134 (class 0 OID 25097)
-- Dependencies: 185
-- Data for Name: palpacion; Type: TABLE DATA; Schema: public; Owner: ganaderia
--

COPY palpacion (id, fecha, numero, mes_gestacion, estado, observaciones, bovino_id) FROM stdin;
1	2013-08-25	1	\N	f	no está preñada	1
2	2013-09-15	2	\N	t	está preñada	1
3	2013-10-10	3	1	t	\N	1
4	2013-11-05	4	2	t	\N	1
5	2013-12-20	5	3	t	\N	1
6	2014-01-16	6	4	t	\N	1
7	2014-02-13	7	5	t	\N	1
8	2014-04-17	8	9	t	\N	1
\.


--
-- TOC entry 2172 (class 0 OID 0)
-- Dependencies: 184
-- Name: palpacion_id_seq; Type: SEQUENCE SET; Schema: public; Owner: ganaderia
--

SELECT pg_catalog.setval('palpacion_id_seq', 8, true);


--
-- TOC entry 2138 (class 0 OID 25133)
-- Dependencies: 189
-- Data for Name: parto; Type: TABLE DATA; Schema: public; Owner: ganaderia
--

COPY parto (id, fecha, resultado, bovino_id, "preñado_id", observaciones) FROM stdin;
1	2014-05-18	nacimiento	1	1	Parto exitoso
\.


--
-- TOC entry 2173 (class 0 OID 0)
-- Dependencies: 188
-- Name: parto_id_seq; Type: SEQUENCE SET; Schema: public; Owner: ganaderia
--

SELECT pg_catalog.setval('parto_id_seq', 1, true);


--
-- TOC entry 2140 (class 0 OID 27239)
-- Dependencies: 191
-- Data for Name: peso; Type: TABLE DATA; Schema: public; Owner: ganaderia
--

COPY peso (id, fecha, peso, bovino_id) FROM stdin;
1	2014-05-17	500	1
2	2014-05-17	450	2
3	2015-05-18	150	3
\.


--
-- TOC entry 2174 (class 0 OID 0)
-- Dependencies: 190
-- Name: peso_id_seq; Type: SEQUENCE SET; Schema: public; Owner: ganaderia
--

SELECT pg_catalog.setval('peso_id_seq', 3, true);


--
-- TOC entry 2135 (class 0 OID 25111)
-- Dependencies: 186
-- Data for Name: preñado; Type: TABLE DATA; Schema: public; Owner: ganaderia
--

COPY "preñado" (id, fecha, ganado_id, observaciones) FROM stdin;
1	2013-09-15	1	\N
\.


--
-- TOC entry 2175 (class 0 OID 0)
-- Dependencies: 187
-- Name: preñado_id_seq; Type: SEQUENCE SET; Schema: public; Owner: ganaderia
--

SELECT pg_catalog.setval('"preñado_id_seq"', 1, true);


--
-- TOC entry 2144 (class 0 OID 27268)
-- Dependencies: 195
-- Data for Name: venta; Type: TABLE DATA; Schema: public; Owner: ganaderia
--

COPY venta (id, fecha, destino, observaciones, precio, bovino_id) FROM stdin;
\.


--
-- TOC entry 2176 (class 0 OID 0)
-- Dependencies: 194
-- Name: venta_id_seq; Type: SEQUENCE SET; Schema: public; Owner: ganaderia
--

SELECT pg_catalog.setval('venta_id_seq', 1, false);


--
-- TOC entry 1975 (class 2606 OID 25012)
-- Name: pk_categoria; Type: CONSTRAINT; Schema: public; Owner: ganaderia; Tablespace: 
--

ALTER TABLE ONLY categoria
    ADD CONSTRAINT pk_categoria PRIMARY KEY (id);


--
-- TOC entry 1983 (class 2606 OID 25068)
-- Name: pk_compra; Type: CONSTRAINT; Schema: public; Owner: ganaderia; Tablespace: 
--

ALTER TABLE ONLY compra
    ADD CONSTRAINT pk_compra PRIMARY KEY (id);


--
-- TOC entry 1977 (class 2606 OID 25023)
-- Name: pk_estancia; Type: CONSTRAINT; Schema: public; Owner: ganaderia; Tablespace: 
--

ALTER TABLE ONLY estancia
    ADD CONSTRAINT pk_estancia PRIMARY KEY (id);


--
-- TOC entry 1979 (class 2606 OID 25031)
-- Name: pk_ganado; Type: CONSTRAINT; Schema: public; Owner: ganaderia; Tablespace: 
--

ALTER TABLE ONLY bovino
    ADD CONSTRAINT pk_ganado PRIMARY KEY (id);


--
-- TOC entry 1985 (class 2606 OID 25084)
-- Name: pk_inseminacion; Type: CONSTRAINT; Schema: public; Owner: ganaderia; Tablespace: 
--

ALTER TABLE ONLY inseminacion
    ADD CONSTRAINT pk_inseminacion PRIMARY KEY (id);


--
-- TOC entry 1995 (class 2606 OID 27260)
-- Name: pk_muerte; Type: CONSTRAINT; Schema: public; Owner: ganaderia; Tablespace: 
--

ALTER TABLE ONLY muerte
    ADD CONSTRAINT pk_muerte PRIMARY KEY (id);


--
-- TOC entry 1981 (class 2606 OID 25052)
-- Name: pk_nacimiento; Type: CONSTRAINT; Schema: public; Owner: ganaderia; Tablespace: 
--

ALTER TABLE ONLY nacimiento
    ADD CONSTRAINT pk_nacimiento PRIMARY KEY (id);


--
-- TOC entry 1987 (class 2606 OID 25105)
-- Name: pk_palpacion; Type: CONSTRAINT; Schema: public; Owner: ganaderia; Tablespace: 
--

ALTER TABLE ONLY palpacion
    ADD CONSTRAINT pk_palpacion PRIMARY KEY (id);


--
-- TOC entry 1991 (class 2606 OID 25141)
-- Name: pk_parto; Type: CONSTRAINT; Schema: public; Owner: ganaderia; Tablespace: 
--

ALTER TABLE ONLY parto
    ADD CONSTRAINT pk_parto PRIMARY KEY (id);


--
-- TOC entry 1993 (class 2606 OID 27244)
-- Name: pk_peso; Type: CONSTRAINT; Schema: public; Owner: ganaderia; Tablespace: 
--

ALTER TABLE ONLY peso
    ADD CONSTRAINT pk_peso PRIMARY KEY (id);


--
-- TOC entry 1989 (class 2606 OID 25124)
-- Name: pk_preñado; Type: CONSTRAINT; Schema: public; Owner: ganaderia; Tablespace: 
--

ALTER TABLE ONLY "preñado"
    ADD CONSTRAINT "pk_preñado" PRIMARY KEY (id);


--
-- TOC entry 1997 (class 2606 OID 27276)
-- Name: pk_venta; Type: CONSTRAINT; Schema: public; Owner: ganaderia; Tablespace: 
--

ALTER TABLE ONLY venta
    ADD CONSTRAINT pk_venta PRIMARY KEY (id);


--
-- TOC entry 1998 (class 2606 OID 25032)
-- Name: fk_categoria; Type: FK CONSTRAINT; Schema: public; Owner: ganaderia
--

ALTER TABLE ONLY bovino
    ADD CONSTRAINT fk_categoria FOREIGN KEY (categoria_id) REFERENCES categoria(id);


--
-- TOC entry 1999 (class 2606 OID 25037)
-- Name: fk_estancia; Type: FK CONSTRAINT; Schema: public; Owner: ganaderia
--

ALTER TABLE ONLY bovino
    ADD CONSTRAINT fk_estancia FOREIGN KEY (estancia_id) REFERENCES estancia(id);


--
-- TOC entry 2000 (class 2606 OID 25053)
-- Name: fk_ganado; Type: FK CONSTRAINT; Schema: public; Owner: ganaderia
--

ALTER TABLE ONLY nacimiento
    ADD CONSTRAINT fk_ganado FOREIGN KEY (bovino_id) REFERENCES bovino(id);


--
-- TOC entry 2002 (class 2606 OID 25069)
-- Name: fk_ganado; Type: FK CONSTRAINT; Schema: public; Owner: ganaderia
--

ALTER TABLE ONLY compra
    ADD CONSTRAINT fk_ganado FOREIGN KEY (bovino_id) REFERENCES bovino(id);


--
-- TOC entry 2005 (class 2606 OID 25106)
-- Name: fk_ganado; Type: FK CONSTRAINT; Schema: public; Owner: ganaderia
--

ALTER TABLE ONLY palpacion
    ADD CONSTRAINT fk_ganado FOREIGN KEY (bovino_id) REFERENCES bovino(id);


--
-- TOC entry 2007 (class 2606 OID 25142)
-- Name: fk_ganado; Type: FK CONSTRAINT; Schema: public; Owner: ganaderia
--

ALTER TABLE ONLY parto
    ADD CONSTRAINT fk_ganado FOREIGN KEY (bovino_id) REFERENCES bovino(id);


--
-- TOC entry 2009 (class 2606 OID 27245)
-- Name: fk_ganado; Type: FK CONSTRAINT; Schema: public; Owner: ganaderia
--

ALTER TABLE ONLY peso
    ADD CONSTRAINT fk_ganado FOREIGN KEY (bovino_id) REFERENCES bovino(id);


--
-- TOC entry 2010 (class 2606 OID 27261)
-- Name: fk_ganado; Type: FK CONSTRAINT; Schema: public; Owner: ganaderia
--

ALTER TABLE ONLY muerte
    ADD CONSTRAINT fk_ganado FOREIGN KEY (bovino_id) REFERENCES bovino(id);


--
-- TOC entry 2011 (class 2606 OID 27277)
-- Name: fk_ganado; Type: FK CONSTRAINT; Schema: public; Owner: ganaderia
--

ALTER TABLE ONLY venta
    ADD CONSTRAINT fk_ganado FOREIGN KEY (bovino_id) REFERENCES bovino(id);


--
-- TOC entry 2004 (class 2606 OID 25090)
-- Name: fk_madre; Type: FK CONSTRAINT; Schema: public; Owner: ganaderia
--

ALTER TABLE ONLY inseminacion
    ADD CONSTRAINT fk_madre FOREIGN KEY (madre_id) REFERENCES bovino(id);


--
-- TOC entry 2003 (class 2606 OID 25085)
-- Name: fk_padre; Type: FK CONSTRAINT; Schema: public; Owner: ganaderia
--

ALTER TABLE ONLY inseminacion
    ADD CONSTRAINT fk_padre FOREIGN KEY (padre_id) REFERENCES bovino(id);


--
-- TOC entry 2001 (class 2606 OID 25152)
-- Name: fk_parto; Type: FK CONSTRAINT; Schema: public; Owner: ganaderia
--

ALTER TABLE ONLY nacimiento
    ADD CONSTRAINT fk_parto FOREIGN KEY (parto_id) REFERENCES parto(id);


--
-- TOC entry 2008 (class 2606 OID 25147)
-- Name: fk_preñado; Type: FK CONSTRAINT; Schema: public; Owner: ganaderia
--

ALTER TABLE ONLY parto
    ADD CONSTRAINT "fk_preñado" FOREIGN KEY ("preñado_id") REFERENCES "preñado"(id);


--
-- TOC entry 2006 (class 2606 OID 25125)
-- Name: fk_vaca; Type: FK CONSTRAINT; Schema: public; Owner: ganaderia
--

ALTER TABLE ONLY "preñado"
    ADD CONSTRAINT fk_vaca FOREIGN KEY (ganado_id) REFERENCES bovino(id);


--
-- TOC entry 2151 (class 0 OID 0)
-- Dependencies: 5
-- Name: public; Type: ACL; Schema: -; Owner: postgres
--

REVOKE ALL ON SCHEMA public FROM PUBLIC;
REVOKE ALL ON SCHEMA public FROM postgres;
GRANT ALL ON SCHEMA public TO postgres;
GRANT ALL ON SCHEMA public TO PUBLIC;


-- Completed on 2015-05-22 16:27:12 BOT

--
-- PostgreSQL database dump complete
--

