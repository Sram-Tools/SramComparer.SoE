﻿using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using Common.Shared.Min.Extensions;
using RosettaStone.Sram.SoE.Constants;
using RosettaStone.Sram.SoE.Models.Structs;

// ReSharper disable InconsistentNaming

namespace SramComparer.SoE.Helpers
{
	/// <summary>List of buffers in sub-structures</summary>
	internal static class UnkownBufferOffsetFinder
	{
		internal const string StructDelimiter = "__";

		public static int GetSaveSlotBufferOffset(string bufferName) => bufferName.Contains(StructDelimiter)
				? (int)bufferName.ParseEnum<SaveSlotUnknownOffset>()
				: (int)Marshal.OffsetOf<SaveSlotDataSoE>(bufferName);

		public static int GetSramBufferOffset(string bufferName) => SramOffsets.SramUnknown1;

		[SuppressMessage("ReSharper", "UnusedMember.Local")]
		[SuppressMessage("ReSharper", "UnusedMember.Global")]
		private enum SaveSlotUnknownOffset
		{
			Unknown4_BoyBuff = SramOffsets.SaveSlot.Unknown4_BoyBuff__BuffFlags, // Offset 112
			Unknown4_BoyBuff__BuffFlags = Unknown4_BoyBuff, // Offset 112
			Unknown4_BoyBuff__Unknown1 = Unknown4_BoyBuff + 2, // Offset 114
			Unknown4_BoyBuff__Unknown2 = Unknown4_BoyBuff + 4, // Offset 116
			Unknown4_BoyBuff__Unknown3 = Unknown4_BoyBuff + 28, // Offset 138
			Unknown4_BoyBuff__Unknown4 = Unknown4_BoyBuff + 30, // Offset 140

			Unknown7_DogBuff = SramOffsets.SaveSlot.Unknown7_DogBuff__BuffFlags, // Offset 177
			Unknown7_DogBuff__BuffFlags = Unknown7_DogBuff, // Offset 177
			Unknown7_DogBuff__Unknown1 = Unknown7_DogBuff + 2, // Offset 179
			Unknown7_DogBuff__Unknown2 = Unknown7_DogBuff + 4, // Offset 181
			Unknown7_DogBuff__Unknown3 = Unknown7_DogBuff + 28, // Offset 203
			Unknown7_DogBuff__Unknown7 = Unknown7_DogBuff + 30, // Offset 205

			Unknown15 = SramOffsets.SaveSlot.Unknown15, // Offset 515
			Unknown15_Offset0To16 = Unknown15, // Offset 515
			Unknown15_Offset17 = Unknown15 + 17, // 532
			Unknown15_Offset18 = Unknown15 + 18, // Offset 533
			Unknown15_Offset19 = Unknown15 + 19, // Offset 534
			Unknown15_Offset20 = Unknown15 + 20, // Offset 535
			Unknown15_Offset21 = Unknown15 + 21, // Offset 536
			Unknown15_Offset22 = Unknown15 + 22, // Offset 537
			Unknown15_Offset23 = Unknown15 + 23, // Offset 538
			Unknown15_Offset24 = Unknown15 + 24, // Offset 539
			Unknown15_Offset25To117 = Unknown15 + 25, // Offset 540

			Unknown16C = SramOffsets.SaveSlot.Unknown16C, // Offset 643
			Unknown16C__Offset1To5 = Unknown16C + 1, // Offset 644
		}
	}
}
