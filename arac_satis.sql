--
-- PostgreSQL database dump
--

-- Dumped from database version 11.10
-- Dumped by pg_dump version 13.1

-- Started on 2020-12-30 15:10:26

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

--
-- TOC entry 247 (class 1255 OID 18839)
-- Name: aracKmDegisimi(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public."aracKmDegisimi"() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
BEGIN
    IF NEW."aracKm" <> OLD."aracKm" THEN
        INSERT INTO "public"."AracKmDegisimiIzle"("aracId", "öncekiKm", "yeniKm", "degisiklikTarihi")
        VALUES(OLD."aracID", OLD."aracKm", NEW."aracKm", CURRENT_TIMESTAMP::TIMESTAMP);
    END IF;

    RETURN NEW;
END;
$$;


ALTER FUNCTION public."aracKmDegisimi"() OWNER TO postgres;

--
-- TOC entry 248 (class 1255 OID 18841)
-- Name: aracSil(integer); Type: PROCEDURE; Schema: public; Owner: postgres
--

CREATE PROCEDURE public."aracSil"(aracid integer)
    LANGUAGE plpgsql
    AS $$
  BEGIN
  
  DELETE FROM "public"."Arac"
  WHERE "aracId" = aracId;
  END;
  $$;


ALTER PROCEDURE public."aracSil"(aracid integer) OWNER TO postgres;

--
-- TOC entry 245 (class 1255 OID 18790)
-- Name: aracara(integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.aracara(markaid integer) RETURNS TABLE(aracmodelid integer, aracmarkaid integer, aracrenkid integer, arackm character varying, aracvitesid integer, aracyakitid integer, aractipid integer)
    LANGUAGE plpgsql
    AS $$
BEGIN

    RETURN QUERY SELECT
        "public"."Arac"."aracModelId",
        "public"."Arac"."aracMarkaId",
        "public"."Arac"."aracRenkId",
        "public"."Arac"."aracKm",
        "public"."Arac"."aracVitesId",
        "public"."Arac"."aracYakitId",
        "public"."Arac"."aracTipId"
    FROM
        "public"."Arac"
    WHERE
        "public"."Arac"."aracMarkaId" LIKE markaID;
END;
$$;


ALTER FUNCTION public.aracara(markaid integer) OWNER TO postgres;

--
-- TOC entry 244 (class 1255 OID 18741)
-- Name: aracekleyeni(integer, integer, integer, integer, integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.aracekleyeni(aracmarka integer, aracrenk integer, vitesturu integer, yakitturu integer, aractur integer) RETURNS void
    LANGUAGE plpgsql
    AS $$  
BEGIN
 INSERT INTO "public"."Arac"
( "aracMarkaId", "aracRenkId", "vitesId","aracYakitId","aracTur")
VALUES ( aracMarka, aracRenk, vitesTuru,yakitTuru,aracTur);
   
END;
$$;


ALTER FUNCTION public.aracekleyeni(aracmarka integer, aracrenk integer, vitesturu integer, yakitturu integer, aractur integer) OWNER TO postgres;

--
-- TOC entry 243 (class 1255 OID 18550)
-- Name: musteriara(character varying); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.musteriara(kullanicitc character varying) RETURNS TABLE(adres character varying, email character varying, musteriad character varying, musterisoyad character varying, tc character varying, musteriid integer)
    LANGUAGE plpgsql
    AS $$
BEGIN

    RETURN QUERY SELECT
        "public"."Musteri"."adres",
        "public"."Musteri"."email",
        "public"."Musteri"."musteriAd",
        "public"."Musteri"."musteriSoyad",
        "public"."Musteri"."Tc",
        "public"."Musteri"."musteriId"
    FROM
        "public"."Musteri"
    WHERE
        "public"."Musteri"."Tc" ILIKE kullaniciTc;
END;
$$;


ALTER FUNCTION public.musteriara(kullanicitc character varying) OWNER TO postgres;

--
-- TOC entry 229 (class 1255 OID 18340)
-- Name: musterikayitekle(character varying, character varying, character varying, character varying, character varying); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.musterikayitekle(adres character varying, email character varying, musteriad character varying, musterisoyad character varying, tc character varying) RETURNS void
    LANGUAGE plpgsql
    AS $$  
BEGIN
 INSERT INTO "public"."Musteri"
("adres", "email", "musteriAd", "musteriSoyad", "Tc")
VALUES (adres, email, musteriAd, musteriSoyad, Tc);
   
END;
$$;


ALTER FUNCTION public.musterikayitekle(adres character varying, email character varying, musteriad character varying, musterisoyad character varying, tc character varying) OWNER TO postgres;

--
-- TOC entry 230 (class 1255 OID 18385)
-- Name: müsterisil(character varying); Type: PROCEDURE; Schema: public; Owner: postgres
--

CREATE PROCEDURE public."müsterisil"(tc character varying)
    LANGUAGE plpgsql
    AS $$
  BEGIN
  
  DELETE FROM "public"."Musteri"
  WHERE "Tc" = Tc;
  END;
  $$;


ALTER PROCEDURE public."müsterisil"(tc character varying) OWNER TO postgres;

--
-- TOC entry 246 (class 1255 OID 18813)
-- Name: toplamkazancarttir(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.toplamkazancarttir() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
   DECLARE 
     eklenecekPara INTEGER;
BEGIN
 eklenecekPara:=(SELECT * FROM "public"."Sözlesme"."alınacakTutar");
 
UPDATE "public"."Arac_Satis" SET "public"."Arac_Satis"."kazanilanToplamPara" = "public"."Arac_Satis"."kazanilanToplamPara" + eklenecekPara;

RETURN NEW;
END;
$$;


ALTER FUNCTION public.toplamkazancarttir() OWNER TO postgres;

SET default_tablespace = '';

--
-- TOC entry 221 (class 1259 OID 18600)
-- Name: Arac; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."Arac" (
    "aracId" integer NOT NULL,
    "aracMarkaId" integer NOT NULL,
    "aracRenkId" integer NOT NULL,
    "aracKm" character varying(15),
    "aracModelId" integer NOT NULL,
    "aracTipId" integer NOT NULL,
    "aracYakitId" integer NOT NULL,
    "aracVitesId" integer NOT NULL,
    "aracResim" character varying(100),
    "aracFiyat" double precision
);


ALTER TABLE public."Arac" OWNER TO postgres;

--
-- TOC entry 228 (class 1259 OID 18830)
-- Name: AracKmDegisimiIzle; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."AracKmDegisimiIzle" (
    "kayitNo" integer NOT NULL,
    "degisiklikTarihi" timestamp without time zone NOT NULL,
    "öncekiKm" character varying NOT NULL,
    "yeniKm" character varying NOT NULL,
    "aracId" integer NOT NULL
);


ALTER TABLE public."AracKmDegisimiIzle" OWNER TO postgres;

--
-- TOC entry 227 (class 1259 OID 18828)
-- Name: AracKmDegisimiIzle_kayitNo_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public."AracKmDegisimiIzle_kayitNo_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public."AracKmDegisimiIzle_kayitNo_seq" OWNER TO postgres;

--
-- TOC entry 3001 (class 0 OID 0)
-- Dependencies: 227
-- Name: AracKmDegisimiIzle_kayitNo_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public."AracKmDegisimiIzle_kayitNo_seq" OWNED BY public."AracKmDegisimiIzle"."kayitNo";


--
-- TOC entry 226 (class 1259 OID 18765)
-- Name: AracTipi; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."AracTipi" (
    tip character varying(20) NOT NULL,
    "tipId" integer NOT NULL
);


ALTER TABLE public."AracTipi" OWNER TO postgres;

--
-- TOC entry 213 (class 1259 OID 18516)
-- Name: Arac_Satis; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."Arac_Satis" (
    "arac_satisId" integer NOT NULL,
    "kazanilanToplamPara" double precision NOT NULL,
    "sözlesmeId" character varying NOT NULL
);


ALTER TABLE public."Arac_Satis" OWNER TO postgres;

--
-- TOC entry 212 (class 1259 OID 18514)
-- Name: Arac_Satis_arac_satisId_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public."Arac_Satis_arac_satisId_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public."Arac_Satis_arac_satisId_seq" OWNER TO postgres;

--
-- TOC entry 3002 (class 0 OID 0)
-- Dependencies: 212
-- Name: Arac_Satis_arac_satisId_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public."Arac_Satis_arac_satisId_seq" OWNED BY public."Arac_Satis"."arac_satisId";


--
-- TOC entry 214 (class 1259 OID 18586)
-- Name: Arac_aracId_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public."Arac_aracId_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public."Arac_aracId_seq" OWNER TO postgres;

--
-- TOC entry 3003 (class 0 OID 0)
-- Dependencies: 214
-- Name: Arac_aracId_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public."Arac_aracId_seq" OWNED BY public."Arac"."aracId";


--
-- TOC entry 215 (class 1259 OID 18588)
-- Name: Arac_aracMarkaId_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public."Arac_aracMarkaId_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public."Arac_aracMarkaId_seq" OWNER TO postgres;

--
-- TOC entry 3004 (class 0 OID 0)
-- Dependencies: 215
-- Name: Arac_aracMarkaId_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public."Arac_aracMarkaId_seq" OWNED BY public."Arac"."aracMarkaId";


--
-- TOC entry 217 (class 1259 OID 18592)
-- Name: Arac_aracModelId_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public."Arac_aracModelId_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public."Arac_aracModelId_seq" OWNER TO postgres;

--
-- TOC entry 3005 (class 0 OID 0)
-- Dependencies: 217
-- Name: Arac_aracModelId_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public."Arac_aracModelId_seq" OWNED BY public."Arac"."aracModelId";


--
-- TOC entry 216 (class 1259 OID 18590)
-- Name: Arac_aracRenkId_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public."Arac_aracRenkId_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public."Arac_aracRenkId_seq" OWNER TO postgres;

--
-- TOC entry 3006 (class 0 OID 0)
-- Dependencies: 216
-- Name: Arac_aracRenkId_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public."Arac_aracRenkId_seq" OWNED BY public."Arac"."aracRenkId";


--
-- TOC entry 218 (class 1259 OID 18594)
-- Name: Arac_aracTur_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public."Arac_aracTur_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public."Arac_aracTur_seq" OWNER TO postgres;

--
-- TOC entry 3007 (class 0 OID 0)
-- Dependencies: 218
-- Name: Arac_aracTur_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public."Arac_aracTur_seq" OWNED BY public."Arac"."aracTipId";


--
-- TOC entry 220 (class 1259 OID 18598)
-- Name: Arac_aracVitesId_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public."Arac_aracVitesId_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public."Arac_aracVitesId_seq" OWNER TO postgres;

--
-- TOC entry 3008 (class 0 OID 0)
-- Dependencies: 220
-- Name: Arac_aracVitesId_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public."Arac_aracVitesId_seq" OWNED BY public."Arac"."aracVitesId";


--
-- TOC entry 219 (class 1259 OID 18596)
-- Name: Arac_aracYakitId_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public."Arac_aracYakitId_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public."Arac_aracYakitId_seq" OWNER TO postgres;

--
-- TOC entry 3009 (class 0 OID 0)
-- Dependencies: 219
-- Name: Arac_aracYakitId_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public."Arac_aracYakitId_seq" OWNED BY public."Arac"."aracYakitId";


--
-- TOC entry 209 (class 1259 OID 18354)
-- Name: Fatura; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."Fatura" (
    "faturaKesimTarihi" character varying(25) NOT NULL,
    "faturaTutari" double precision NOT NULL,
    "faturaKesen" character varying(30) NOT NULL,
    "faturaKesilen" character varying(30) NOT NULL,
    "faturaId" integer NOT NULL
);


ALTER TABLE public."Fatura" OWNER TO postgres;

--
-- TOC entry 208 (class 1259 OID 18352)
-- Name: Fatura_faturaId_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public."Fatura_faturaId_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public."Fatura_faturaId_seq" OWNER TO postgres;

--
-- TOC entry 3010 (class 0 OID 0)
-- Dependencies: 208
-- Name: Fatura_faturaId_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public."Fatura_faturaId_seq" OWNED BY public."Fatura"."faturaId";


--
-- TOC entry 207 (class 1259 OID 18343)
-- Name: Kisi; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."Kisi" (
    adres character varying(15) NOT NULL,
    email character varying(15) NOT NULL,
    "kisiAd" character varying(15) NOT NULL,
    "kisiSoyad" character varying(15) NOT NULL,
    "kisiId" integer NOT NULL,
    "Tc" character varying(15) NOT NULL
);


ALTER TABLE public."Kisi" OWNER TO postgres;

--
-- TOC entry 206 (class 1259 OID 18341)
-- Name: Kisi_kisiId_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public."Kisi_kisiId_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public."Kisi_kisiId_seq" OWNER TO postgres;

--
-- TOC entry 3011 (class 0 OID 0)
-- Dependencies: 206
-- Name: Kisi_kisiId_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public."Kisi_kisiId_seq" OWNED BY public."Kisi"."kisiId";


--
-- TOC entry 203 (class 1259 OID 18316)
-- Name: Marka; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."Marka" (
    "markaAd" character varying(20) NOT NULL,
    "markaId" integer NOT NULL
);


ALTER TABLE public."Marka" OWNER TO postgres;

--
-- TOC entry 202 (class 1259 OID 18314)
-- Name: Marka_markaId_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public."Marka_markaId_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public."Marka_markaId_seq" OWNER TO postgres;

--
-- TOC entry 3012 (class 0 OID 0)
-- Dependencies: 202
-- Name: Marka_markaId_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public."Marka_markaId_seq" OWNED BY public."Marka"."markaId";


--
-- TOC entry 223 (class 1259 OID 18629)
-- Name: Model; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."Model" (
    "modelId" integer NOT NULL,
    "Model" character varying(15) NOT NULL
);


ALTER TABLE public."Model" OWNER TO postgres;

--
-- TOC entry 222 (class 1259 OID 18627)
-- Name: Model_modelId_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public."Model_modelId_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public."Model_modelId_seq" OWNER TO postgres;

--
-- TOC entry 3013 (class 0 OID 0)
-- Dependencies: 222
-- Name: Model_modelId_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public."Model_modelId_seq" OWNED BY public."Model"."modelId";


--
-- TOC entry 196 (class 1259 OID 18227)
-- Name: Musteri; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."Musteri" (
    adres character varying(25) NOT NULL,
    email character varying(25) NOT NULL,
    "musteriAd" character varying(25) NOT NULL,
    "musteriSoyad" character varying(25) NOT NULL,
    "Tc" character varying(25) NOT NULL,
    "musteriId" integer NOT NULL
);


ALTER TABLE public."Musteri" OWNER TO postgres;

--
-- TOC entry 197 (class 1259 OID 18230)
-- Name: Musteri_musteriId_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public."Musteri_musteriId_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public."Musteri_musteriId_seq" OWNER TO postgres;

--
-- TOC entry 3014 (class 0 OID 0)
-- Dependencies: 197
-- Name: Musteri_musteriId_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public."Musteri_musteriId_seq" OWNED BY public."Musteri"."musteriId";


--
-- TOC entry 201 (class 1259 OID 18302)
-- Name: Personel; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."Personel" (
    "personelAd" character varying(15) NOT NULL,
    "personelSoyad" character varying(15) NOT NULL,
    "personelId" integer NOT NULL,
    "personelTc" character varying(15),
    "ersonelAdres" character varying(25),
    "personelMail" character varying(25)
);


ALTER TABLE public."Personel" OWNER TO postgres;

--
-- TOC entry 200 (class 1259 OID 18300)
-- Name: Personel_personelId_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public."Personel_personelId_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public."Personel_personelId_seq" OWNER TO postgres;

--
-- TOC entry 3015 (class 0 OID 0)
-- Dependencies: 200
-- Name: Personel_personelId_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public."Personel_personelId_seq" OWNED BY public."Personel"."personelId";


--
-- TOC entry 225 (class 1259 OID 18752)
-- Name: Renk; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."Renk" (
    "renkAd" character varying NOT NULL,
    "renkId" integer NOT NULL
);


ALTER TABLE public."Renk" OWNER TO postgres;

--
-- TOC entry 199 (class 1259 OID 18257)
-- Name: Sözlesme; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."Sözlesme" (
    "sözlesmeTarihi" character varying(20) NOT NULL,
    "alınacakTutar" double precision NOT NULL,
    "müsteriAd" character varying(15) NOT NULL,
    "personelAd" character varying(15) NOT NULL,
    "sözlesmeId" character varying NOT NULL,
    "aracModel" character varying(20) NOT NULL,
    "aracMarka" character varying(20) NOT NULL,
    "aracKm" character varying(20) NOT NULL,
    "müsteriSoyad" character varying(20) NOT NULL,
    "personelSoyad" character varying(20) NOT NULL,
    "müsteriTc" character varying(25) NOT NULL,
    "ödemeTipi" character varying(20) NOT NULL,
    "müsteriAdres" character varying(25) NOT NULL,
    "müsteriMail" character varying(25) NOT NULL
);


ALTER TABLE public."Sözlesme" OWNER TO postgres;

--
-- TOC entry 198 (class 1259 OID 18255)
-- Name: Sözlesme_sözlesmeId_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public."Sözlesme_sözlesmeId_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public."Sözlesme_sözlesmeId_seq" OWNER TO postgres;

--
-- TOC entry 3016 (class 0 OID 0)
-- Dependencies: 198
-- Name: Sözlesme_sözlesmeId_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public."Sözlesme_sözlesmeId_seq" OWNED BY public."Sözlesme"."sözlesmeId";


--
-- TOC entry 224 (class 1259 OID 18725)
-- Name: Vites-Turu; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."Vites-Turu" (
    "vitesAd" character varying(20) NOT NULL,
    "vitesId" integer NOT NULL
);


ALTER TABLE public."Vites-Turu" OWNER TO postgres;

--
-- TOC entry 211 (class 1259 OID 18369)
-- Name: Yakit-Turu; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."Yakit-Turu" (
    "yakitAd" character varying(20) NOT NULL,
    "yakitId" integer NOT NULL
);


ALTER TABLE public."Yakit-Turu" OWNER TO postgres;

--
-- TOC entry 210 (class 1259 OID 18367)
-- Name: Yakit-Turu_turId_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public."Yakit-Turu_turId_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public."Yakit-Turu_turId_seq" OWNER TO postgres;

--
-- TOC entry 3017 (class 0 OID 0)
-- Dependencies: 210
-- Name: Yakit-Turu_turId_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public."Yakit-Turu_turId_seq" OWNED BY public."Yakit-Turu"."yakitId";


--
-- TOC entry 205 (class 1259 OID 18326)
-- Name: ÖdemeTipi; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."ÖdemeTipi" (
    "ödemeId" integer NOT NULL,
    "ödemeTuru" character varying(20) NOT NULL
);


ALTER TABLE public."ÖdemeTipi" OWNER TO postgres;

--
-- TOC entry 204 (class 1259 OID 18324)
-- Name: ÖdemeTipi_ödemeId_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public."ÖdemeTipi_ödemeId_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public."ÖdemeTipi_ödemeId_seq" OWNER TO postgres;

--
-- TOC entry 3018 (class 0 OID 0)
-- Dependencies: 204
-- Name: ÖdemeTipi_ödemeId_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public."ÖdemeTipi_ödemeId_seq" OWNED BY public."ÖdemeTipi"."ödemeId";


--
-- TOC entry 2796 (class 2604 OID 18603)
-- Name: Arac aracId; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Arac" ALTER COLUMN "aracId" SET DEFAULT nextval('public."Arac_aracId_seq"'::regclass);


--
-- TOC entry 2797 (class 2604 OID 18604)
-- Name: Arac aracMarkaId; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Arac" ALTER COLUMN "aracMarkaId" SET DEFAULT nextval('public."Arac_aracMarkaId_seq"'::regclass);


--
-- TOC entry 2798 (class 2604 OID 18605)
-- Name: Arac aracRenkId; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Arac" ALTER COLUMN "aracRenkId" SET DEFAULT nextval('public."Arac_aracRenkId_seq"'::regclass);


--
-- TOC entry 2799 (class 2604 OID 18606)
-- Name: Arac aracModelId; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Arac" ALTER COLUMN "aracModelId" SET DEFAULT nextval('public."Arac_aracModelId_seq"'::regclass);


--
-- TOC entry 2800 (class 2604 OID 18607)
-- Name: Arac aracTipId; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Arac" ALTER COLUMN "aracTipId" SET DEFAULT nextval('public."Arac_aracTur_seq"'::regclass);


--
-- TOC entry 2801 (class 2604 OID 18608)
-- Name: Arac aracYakitId; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Arac" ALTER COLUMN "aracYakitId" SET DEFAULT nextval('public."Arac_aracYakitId_seq"'::regclass);


--
-- TOC entry 2802 (class 2604 OID 18609)
-- Name: Arac aracVitesId; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Arac" ALTER COLUMN "aracVitesId" SET DEFAULT nextval('public."Arac_aracVitesId_seq"'::regclass);


--
-- TOC entry 2804 (class 2604 OID 18833)
-- Name: AracKmDegisimiIzle kayitNo; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."AracKmDegisimiIzle" ALTER COLUMN "kayitNo" SET DEFAULT nextval('public."AracKmDegisimiIzle_kayitNo_seq"'::regclass);


--
-- TOC entry 2795 (class 2604 OID 18523)
-- Name: Arac_Satis arac_satisId; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Arac_Satis" ALTER COLUMN "arac_satisId" SET DEFAULT nextval('public."Arac_Satis_arac_satisId_seq"'::regclass);


--
-- TOC entry 2793 (class 2604 OID 18357)
-- Name: Fatura faturaId; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Fatura" ALTER COLUMN "faturaId" SET DEFAULT nextval('public."Fatura_faturaId_seq"'::regclass);


--
-- TOC entry 2792 (class 2604 OID 18346)
-- Name: Kisi kisiId; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Kisi" ALTER COLUMN "kisiId" SET DEFAULT nextval('public."Kisi_kisiId_seq"'::regclass);


--
-- TOC entry 2790 (class 2604 OID 18319)
-- Name: Marka markaId; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Marka" ALTER COLUMN "markaId" SET DEFAULT nextval('public."Marka_markaId_seq"'::regclass);


--
-- TOC entry 2803 (class 2604 OID 18632)
-- Name: Model modelId; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Model" ALTER COLUMN "modelId" SET DEFAULT nextval('public."Model_modelId_seq"'::regclass);


--
-- TOC entry 2787 (class 2604 OID 18232)
-- Name: Musteri musteriId; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Musteri" ALTER COLUMN "musteriId" SET DEFAULT nextval('public."Musteri_musteriId_seq"'::regclass);


--
-- TOC entry 2789 (class 2604 OID 18804)
-- Name: Personel personelId; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Personel" ALTER COLUMN "personelId" SET DEFAULT nextval('public."Personel_personelId_seq"'::regclass);


--
-- TOC entry 2788 (class 2604 OID 18873)
-- Name: Sözlesme sözlesmeId; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Sözlesme" ALTER COLUMN "sözlesmeId" SET DEFAULT nextval('public."Sözlesme_sözlesmeId_seq"'::regclass);


--
-- TOC entry 2794 (class 2604 OID 18372)
-- Name: Yakit-Turu yakitId; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Yakit-Turu" ALTER COLUMN "yakitId" SET DEFAULT nextval('public."Yakit-Turu_turId_seq"'::regclass);


--
-- TOC entry 2791 (class 2604 OID 18329)
-- Name: ÖdemeTipi ödemeId; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."ÖdemeTipi" ALTER COLUMN "ödemeId" SET DEFAULT nextval('public."ÖdemeTipi_ödemeId_seq"'::regclass);


--
-- TOC entry 2988 (class 0 OID 18600)
-- Dependencies: 221
-- Data for Name: Arac; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public."Arac" ("aracId", "aracMarkaId", "aracRenkId", "aracKm", "aracModelId", "aracTipId", "aracYakitId", "aracVitesId", "aracResim", "aracFiyat") FROM stdin;
35	1	2	28.000	3	2	1	1	D:\\SAU\\VERİ TABANI YÖNETİM SİSTEMLERİ\\fotoğraflar\\kuga.jpg	198000
40	3	2	123.500	10	1	1	1	D:\\SAU\\VERİ TABANI YÖNETİM SİSTEMLERİ\\fotoğraflar\\bmw320.jpg	178900
37	1	3	8000	1	1	1	1	D:\\SAU\\VERİ TABANI YÖNETİM SİSTEMLERİ\\fotoğraflar\\maviFocus.jpg	215000
38	2	7	3000	12	1	1	1	D:\\SAU\\VERİ TABANI YÖNETİM SİSTEMLERİ\\fotoğraflar\\yesilc180.jpg	372000
41	6	5	14.700	16	1	3	1	D:\\SAU\\VERİ TABANI YÖNETİM SİSTEMLERİ\\fotoğraflar\\civic_19.jpg	198000
42	4	6	198.000	7	1	3	2	D:\\SAU\\VERİ TABANI YÖNETİM SİSTEMLERİ\\fotoğraflar\\corsa.jpg	69850
39	5	2	78.000	4	1	2	3	D:\\SAU\\VERİ TABANI YÖNETİM SİSTEMLERİ\\fotoğraflar\\megane.jpg	188500
\.


--
-- TOC entry 2995 (class 0 OID 18830)
-- Dependencies: 228
-- Data for Name: AracKmDegisimiIzle; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public."AracKmDegisimiIzle" ("kayitNo", "degisiklikTarihi", "öncekiKm", "yeniKm", "aracId") FROM stdin;
\.


--
-- TOC entry 2993 (class 0 OID 18765)
-- Dependencies: 226
-- Data for Name: AracTipi; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public."AracTipi" (tip, "tipId") FROM stdin;
OTOMOBİL	1
SUV	2
KAMYONET	3
MOTOSİKLET	4
\.


--
-- TOC entry 2980 (class 0 OID 18516)
-- Dependencies: 213
-- Data for Name: Arac_Satis; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public."Arac_Satis" ("arac_satisId", "kazanilanToplamPara", "sözlesmeId") FROM stdin;
4	178900	95
\.


--
-- TOC entry 2976 (class 0 OID 18354)
-- Dependencies: 209
-- Data for Name: Fatura; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public."Fatura" ("faturaKesimTarihi", "faturaTutari", "faturaKesen", "faturaKesilen", "faturaId") FROM stdin;
30.12.2020	178900	BerkayÖzdağ	SelimÖztürk	1
\.


--
-- TOC entry 2974 (class 0 OID 18343)
-- Dependencies: 207
-- Data for Name: Kisi; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public."Kisi" (adres, email, "kisiAd", "kisiSoyad", "kisiId", "Tc") FROM stdin;
\.


--
-- TOC entry 2970 (class 0 OID 18316)
-- Dependencies: 203
-- Data for Name: Marka; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public."Marka" ("markaAd", "markaId") FROM stdin;
FORD	1
MERCEDES	2
BMW	3
OPEL	4
RENAULT	5
HONDA	6
SEAT	7
\.


--
-- TOC entry 2990 (class 0 OID 18629)
-- Dependencies: 223
-- Data for Name: Model; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public."Model" ("modelId", "Model") FROM stdin;
1	FOCUS
2	FİESTA
3	KUGA
4	MEGANE
5	CLIO
6	ASTRA
7	CORSA
8	VECTRA
9	INSIGNIA
10	320
11	520
12	C180
13	C200
14	MONDEO
15	CITY
16	CIVIC
\.


--
-- TOC entry 2963 (class 0 OID 18227)
-- Dependencies: 196
-- Data for Name: Musteri; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public."Musteri" (adres, email, "musteriAd", "musteriSoyad", "Tc", "musteriId") FROM stdin;
Rize/çayeli	davut@gmail.com	Davut	Tombul	789456	34
zonguldak/ereğli	kadir@gmail.com	kadir	çelik	33333	35
İstanbul	fergun53@gmail.com	Furkan	Ergün	123456	33
İzmir/Bornova	slm@gmail.com	Selim	Öztürk	147258369	36
\.


--
-- TOC entry 2968 (class 0 OID 18302)
-- Dependencies: 201
-- Data for Name: Personel; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public."Personel" ("personelAd", "personelSoyad", "personelId", "personelTc", "ersonelAdres", "personelMail") FROM stdin;
Berkay	Özdağ	1	010203	\N	\N
Burak 	Özdağ	2	123456	\N	\N
\.


--
-- TOC entry 2992 (class 0 OID 18752)
-- Dependencies: 225
-- Data for Name: Renk; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public."Renk" ("renkAd", "renkId") FROM stdin;
SİYAH	1
BEYAZ	2
LACİVERT	3
KIRMIZI	4
GRİ	5
GÜMÜŞ GRİ	6
YEŞİL	7
\.


--
-- TOC entry 2966 (class 0 OID 18257)
-- Dependencies: 199
-- Data for Name: Sözlesme; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public."Sözlesme" ("sözlesmeTarihi", "alınacakTutar", "müsteriAd", "personelAd", "sözlesmeId", "aracModel", "aracMarka", "aracKm", "müsteriSoyad", "personelSoyad", "müsteriTc", "ödemeTipi", "müsteriAdres", "müsteriMail") FROM stdin;
30.12.2020 14:28:05	178900	Selim	Berkay	95	320	BMW	123.500	Öztürk	Özdağ	147258369	PEŞİN	İzmir/Bornova	slm@gmail.com
\.


--
-- TOC entry 2991 (class 0 OID 18725)
-- Dependencies: 224
-- Data for Name: Vites-Turu; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public."Vites-Turu" ("vitesAd", "vitesId") FROM stdin;
OTOMATİK	1
MANUEL	2
YARI-OTOMATİK	3
\.


--
-- TOC entry 2978 (class 0 OID 18369)
-- Dependencies: 211
-- Data for Name: Yakit-Turu; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public."Yakit-Turu" ("yakitAd", "yakitId") FROM stdin;
BENZİN	1
DİZEL	2
BENZİN-LPG	3
LPG	4
\.


--
-- TOC entry 2972 (class 0 OID 18326)
-- Dependencies: 205
-- Data for Name: ÖdemeTipi; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public."ÖdemeTipi" ("ödemeId", "ödemeTuru") FROM stdin;
1	PEŞİN
2	3 TAKSİT
3	6 TAKSİT
\.


--
-- TOC entry 3019 (class 0 OID 0)
-- Dependencies: 227
-- Name: AracKmDegisimiIzle_kayitNo_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."AracKmDegisimiIzle_kayitNo_seq"', 1, false);


--
-- TOC entry 3020 (class 0 OID 0)
-- Dependencies: 212
-- Name: Arac_Satis_arac_satisId_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."Arac_Satis_arac_satisId_seq"', 4, true);


--
-- TOC entry 3021 (class 0 OID 0)
-- Dependencies: 214
-- Name: Arac_aracId_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."Arac_aracId_seq"', 42, true);


--
-- TOC entry 3022 (class 0 OID 0)
-- Dependencies: 215
-- Name: Arac_aracMarkaId_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."Arac_aracMarkaId_seq"', 1, false);


--
-- TOC entry 3023 (class 0 OID 0)
-- Dependencies: 217
-- Name: Arac_aracModelId_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."Arac_aracModelId_seq"', 15, true);


--
-- TOC entry 3024 (class 0 OID 0)
-- Dependencies: 216
-- Name: Arac_aracRenkId_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."Arac_aracRenkId_seq"', 4, true);


--
-- TOC entry 3025 (class 0 OID 0)
-- Dependencies: 218
-- Name: Arac_aracTur_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."Arac_aracTur_seq"', 5, true);


--
-- TOC entry 3026 (class 0 OID 0)
-- Dependencies: 220
-- Name: Arac_aracVitesId_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."Arac_aracVitesId_seq"', 4, true);


--
-- TOC entry 3027 (class 0 OID 0)
-- Dependencies: 219
-- Name: Arac_aracYakitId_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."Arac_aracYakitId_seq"', 4, true);


--
-- TOC entry 3028 (class 0 OID 0)
-- Dependencies: 208
-- Name: Fatura_faturaId_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."Fatura_faturaId_seq"', 1, true);


--
-- TOC entry 3029 (class 0 OID 0)
-- Dependencies: 206
-- Name: Kisi_kisiId_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."Kisi_kisiId_seq"', 1, false);


--
-- TOC entry 3030 (class 0 OID 0)
-- Dependencies: 202
-- Name: Marka_markaId_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."Marka_markaId_seq"', 7, true);


--
-- TOC entry 3031 (class 0 OID 0)
-- Dependencies: 222
-- Name: Model_modelId_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."Model_modelId_seq"', 16, true);


--
-- TOC entry 3032 (class 0 OID 0)
-- Dependencies: 197
-- Name: Musteri_musteriId_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."Musteri_musteriId_seq"', 36, true);


--
-- TOC entry 3033 (class 0 OID 0)
-- Dependencies: 200
-- Name: Personel_personelId_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."Personel_personelId_seq"', 1, false);


--
-- TOC entry 3034 (class 0 OID 0)
-- Dependencies: 198
-- Name: Sözlesme_sözlesmeId_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."Sözlesme_sözlesmeId_seq"', 12, true);


--
-- TOC entry 3035 (class 0 OID 0)
-- Dependencies: 210
-- Name: Yakit-Turu_turId_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."Yakit-Turu_turId_seq"', 4, true);


--
-- TOC entry 3036 (class 0 OID 0)
-- Dependencies: 204
-- Name: ÖdemeTipi_ödemeId_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."ÖdemeTipi_ödemeId_seq"', 1, true);


--
-- TOC entry 2834 (class 2606 OID 18838)
-- Name: AracKmDegisimiIzle AracKmDegisimiIzle_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."AracKmDegisimiIzle"
    ADD CONSTRAINT "AracKmDegisimiIzle_pkey" PRIMARY KEY ("kayitNo");


--
-- TOC entry 2832 (class 2606 OID 18769)
-- Name: AracTipi AracTipi_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."AracTipi"
    ADD CONSTRAINT "AracTipi_pkey" PRIMARY KEY ("tipId");


--
-- TOC entry 2822 (class 2606 OID 18525)
-- Name: Arac_Satis Arac_Satis_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Arac_Satis"
    ADD CONSTRAINT "Arac_Satis_pkey" PRIMARY KEY ("arac_satisId");


--
-- TOC entry 2824 (class 2606 OID 18611)
-- Name: Arac Arac_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Arac"
    ADD CONSTRAINT "Arac_pkey" PRIMARY KEY ("aracId");


--
-- TOC entry 2818 (class 2606 OID 18474)
-- Name: Fatura Fatura_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Fatura"
    ADD CONSTRAINT "Fatura_pkey" PRIMARY KEY ("faturaId");


--
-- TOC entry 2816 (class 2606 OID 18348)
-- Name: Kisi Kisi_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Kisi"
    ADD CONSTRAINT "Kisi_pkey" PRIMARY KEY ("kisiId");


--
-- TOC entry 2812 (class 2606 OID 18335)
-- Name: Marka Marka_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Marka"
    ADD CONSTRAINT "Marka_pkey" PRIMARY KEY ("markaId");


--
-- TOC entry 2826 (class 2606 OID 18634)
-- Name: Model Model_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Model"
    ADD CONSTRAINT "Model_pkey" PRIMARY KEY ("modelId");


--
-- TOC entry 2806 (class 2606 OID 18237)
-- Name: Musteri Musteri_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Musteri"
    ADD CONSTRAINT "Musteri_pkey" PRIMARY KEY ("musteriId");


--
-- TOC entry 2810 (class 2606 OID 18799)
-- Name: Personel Personel_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Personel"
    ADD CONSTRAINT "Personel_pkey" PRIMARY KEY ("personelId");


--
-- TOC entry 2830 (class 2606 OID 18759)
-- Name: Renk Renk_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Renk"
    ADD CONSTRAINT "Renk_pkey" PRIMARY KEY ("renkId");


--
-- TOC entry 2808 (class 2606 OID 18865)
-- Name: Sözlesme Sözlesme_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Sözlesme"
    ADD CONSTRAINT "Sözlesme_pkey" PRIMARY KEY ("sözlesmeId");


--
-- TOC entry 2828 (class 2606 OID 18729)
-- Name: Vites-Turu Vites-Turu_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Vites-Turu"
    ADD CONSTRAINT "Vites-Turu_pkey" PRIMARY KEY ("vitesId");


--
-- TOC entry 2820 (class 2606 OID 18480)
-- Name: Yakit-Turu Yakit-Turu_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Yakit-Turu"
    ADD CONSTRAINT "Yakit-Turu_pkey" PRIMARY KEY ("yakitId");


--
-- TOC entry 2814 (class 2606 OID 18331)
-- Name: ÖdemeTipi ÖdemeTipi_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."ÖdemeTipi"
    ADD CONSTRAINT "ÖdemeTipi_pkey" PRIMARY KEY ("ödemeId");


--
-- TOC entry 2836 (class 2606 OID 18612)
-- Name: Arac arac_marka; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Arac"
    ADD CONSTRAINT arac_marka FOREIGN KEY ("aracMarkaId") REFERENCES public."Marka"("markaId") MATCH FULL ON UPDATE CASCADE ON DELETE CASCADE;


--
-- TOC entry 2839 (class 2606 OID 18747)
-- Name: Arac arac_model; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Arac"
    ADD CONSTRAINT arac_model FOREIGN KEY ("aracModelId") REFERENCES public."Model"("modelId") MATCH FULL ON UPDATE CASCADE ON DELETE CASCADE;


--
-- TOC entry 2840 (class 2606 OID 18760)
-- Name: Arac arac_renk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Arac"
    ADD CONSTRAINT arac_renk FOREIGN KEY ("aracRenkId") REFERENCES public."Renk"("renkId") MATCH FULL ON UPDATE CASCADE ON DELETE CASCADE;


--
-- TOC entry 2841 (class 2606 OID 18770)
-- Name: Arac arac_tip; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Arac"
    ADD CONSTRAINT arac_tip FOREIGN KEY ("aracTipId") REFERENCES public."AracTipi"("tipId") MATCH FULL ON UPDATE CASCADE ON DELETE CASCADE;


--
-- TOC entry 2838 (class 2606 OID 18730)
-- Name: Arac arac_vites; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Arac"
    ADD CONSTRAINT arac_vites FOREIGN KEY ("aracVitesId") REFERENCES public."Vites-Turu"("vitesId") MATCH FULL ON UPDATE CASCADE ON DELETE CASCADE;


--
-- TOC entry 2837 (class 2606 OID 18710)
-- Name: Arac arac_yakit; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Arac"
    ADD CONSTRAINT arac_yakit FOREIGN KEY ("aracYakitId") REFERENCES public."Yakit-Turu"("yakitId") MATCH FULL ON UPDATE CASCADE ON DELETE CASCADE;


--
-- TOC entry 2835 (class 2606 OID 18874)
-- Name: Arac_Satis sözlesme_satis; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Arac_Satis"
    ADD CONSTRAINT "sözlesme_satis" FOREIGN KEY ("sözlesmeId") REFERENCES public."Sözlesme"("sözlesmeId") MATCH FULL ON UPDATE CASCADE ON DELETE CASCADE;


-- Completed on 2020-12-30 15:10:26

--
-- PostgreSQL database dump complete
--

