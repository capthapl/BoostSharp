	/* Data SHA1: 7ea2bb3815efefda43845215f2dfd6c0daf4003c */
	.file	"typemap.mj.inc"

	/* Mapping header */
	.section	.data.mj_typemap,"aw",@progbits
	.type	mj_typemap_header, @object
	.p2align	2
	.global	mj_typemap_header
mj_typemap_header:
	/* version */
	.long	1
	/* entry-count */
	.long	1862
	/* entry-length */
	.long	280
	/* value-offset */
	.long	163
	.size	mj_typemap_header, 16

	/* Mapping data */
	.type	mj_typemap, @object
	.global	mj_typemap
mj_typemap:
	.size	mj_typemap, 521361
	.include	"typemap.mj.inc"
